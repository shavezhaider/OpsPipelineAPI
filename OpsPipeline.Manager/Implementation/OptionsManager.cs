using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OpsPipelineAPI.Entities.Response;
using OpsPipelineAPI.Manager.Interface;
using OpsPipelineAPI.Repository.EDMX;

using OpsPipelineAPI.Repository.Interface;
using OpsPipelineAPI.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OpsPipelineAPI.Utilities.Enums;

namespace OpsPipelineAPI.Manager.Implementation
{
    public class OptionsManager : IOptionsSelect
    {
        //private IBaseRepository<CountryMaster> _repository;
        ReportContext _dbContext;
        public OptionsManager(IServiceProvider serviceProvider, ReportContext reportContext)
        {
            _dbContext= reportContext;
            ResolveRepository(serviceProvider);
        }

        public async Task<List<OptionsResponse>> GetOptionByTypeId(int type)
        {

            List<OptionsResponse > options = new List<OptionsResponse>();
            if (type == (int)enumOptionType.entirePipeline)
            {
              var viewRes=  _dbContext.testView.ToList();
                options = (from a in _dbContext.MasterCountries
                           select new OptionsResponse
                           {
                               Id = a.CountryId,
                               Name = a.CountryName
                           }).ToList();
            }
            else if (type == (int)enumOptionType.dealLocation)
            {
                

            }
            else if (type == (int)enumOptionType.SalesStage)
            {
              

            }
            else if (type == (int)enumOptionType.topDeal)
            {
                

            }
            return options;

           
        }
        private void ResolveRepository(IServiceProvider serviceProvider)
        {
            //  _repository = serviceProvider.GetService<IBaseRepository<CUSTOMER>>();
          //  _repository = serviceProvider.GetService<IBaseRepository<CountryMaster>>();
        }
    }
}
