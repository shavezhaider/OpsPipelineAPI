using Microsoft.EntityFrameworkCore;
using OpsPipelineAPI.Manager.Interface;
using OpsPipelineAPI.Repository.EDMX;
using OpsPipelineAPI.Repository.Interface;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace OpsPipelineAPI.Manager.Implementation
{
    public class SettingManager : ISetting
    {
            
        private readonly OpsPipelineDBContext _dbContext;
        public SettingManager(OpsPipelineDBContext  dbContext)
        {
            _dbContext = dbContext;            
        }
        public Setting GetSettingByName(string Name)
        {          
            var result = _dbContext.Settings.Where(x => x.Name == Name).FirstOrDefault();            
            return result;           
        }

      

    }
}
