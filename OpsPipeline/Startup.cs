using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.OpenApi.Models;
using System.IO;
using MediatR;
using OpsPipelineAPI.Manager.Helper;
using System.Text.Json.Serialization;
using OpsPipelineAPI.Manager.Interface;
using OpsPipelineAPI.Manager.Implementation;
using OpsPipelineAPI.Repository.Interface;
using OpsPipelineAPI.Repository.Implementation;
using OpsPipelineAPI.Repository.EDMX;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Identity;
using OpsPipelineAPI.Repository.Models;

namespace OpsPipelineAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            //services.AddCors(c =>
            //{
            //    c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            //});

            

            services.AddControllers(config =>
            {
                config.Filters.Add(typeof(ExceptionFilter));
            }).
           
            AddJsonOptions(x =>
            {
                x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            });

            #region 
            // JWT token configuration 
            var jwtSettings = Configuration.GetSection("JwtSettings");
            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,

                    ValidIssuer = jwtSettings.GetSection("validIssuer").Value,
                    ValidAudience = jwtSettings.GetSection("validAudience").Value,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.GetSection("securityKey").Value))
                };
            });
            //--------------------------------------
            #endregion
            // Email Service
            var emailConfig = Configuration.GetSection("EmailConfiguration");
            services.AddScoped<IEmailSender, EmailSenderManager>();





            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            
            services.AddTransient<IUser, UserManagerRepo>();
          
            services.AddTransient<IOptionsSelect, OptionsManager>();
            services.AddTransient<IReports, ReportsManager>();
            

            services.AddScoped<JwtHandler>();
            services.AddDbContext<OpsPipelineDBContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("OpsPipelineEntities")));

            services.AddDbContext<ReportContext>(options =>
             options.UseSqlServer(Configuration.GetConnectionString("SalesForceEntities")));

            services.AddIdentity<AppUser, IdentityRole>(opt =>
            {
                opt.Password.RequiredLength = 6;
                opt.Password.RequireDigit = false;
                opt.Password.RequireUppercase = false;
                opt.User.RequireUniqueEmail = true;
            })
             .AddEntityFrameworkStores<OpsPipelineDBContext>()
             .AddDefaultTokenProviders();

            services.Configure<DataProtectionTokenProviderOptions>(opt => opt.TokenLifespan = TimeSpan.FromHours(2));

            services.AddScoped<DbContext, OpsPipelineDBContext>();
            services.AddScoped<DbContext, ReportContext>();
            services.AddAutoMapper(typeof(AutoMapperProfile));
            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
            ConfigurSwagger(services);
            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env , RoleManager<IdentityRole> roleManager)
        {
            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            Task.Run(() => this.CreateRoles(roleManager)).Wait();
            EnableSwagger(app);
        }
        private async Task CreateRoles(RoleManager<IdentityRole> roleManager)
        {
            foreach (string rol in this.Configuration.GetSection("Roles").Get<List<string>>())
            {
                if (!await roleManager.RoleExistsAsync(rol))
                {
                    await roleManager.CreateAsync(new IdentityRole(rol));
                }
            }
        }
        private void ConfigurSwagger(IServiceCollection services)
        {           

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "OpsPipeline APIs", Version = "v1.0.0" });              


            });
        }
        private void EnableSwagger(IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "OpsPipeline API v1");

            });
        }
    }
}
