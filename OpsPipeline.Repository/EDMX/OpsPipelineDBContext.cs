using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace OpsPipelineAPI.Repository.EDMX
{
    public class OpsPipelineDBContext : IdentityDbContext<AppUser> // : IdentityDbContext //Microsoft.AspNet.Identity.EntityFramework.IdentityDbContext<ApplicationUser>
    {
        public OpsPipelineDBContext()
        {

        }
        public OpsPipelineDBContext(DbContextOptions<OpsPipelineDBContext> options) : base(options)
        {

        }
        public virtual DbSet<AGENTS> AGENTS { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
