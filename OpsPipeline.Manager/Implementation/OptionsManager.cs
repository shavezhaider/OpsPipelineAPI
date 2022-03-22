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
        private IBaseRepository<MasterCountry> _repository;
        private IBaseRepository<Customer> _repoCustomer;
        private IBaseRepository<testView> _repoView;
        private IBaseRepository<AGENTS> _repoAgent;
        //ReportContext _dbContext;
        OpsPipelineDBContext _dbContext;
        public OptionsManager(IServiceProvider serviceProvider, ReportContext reportContext, OpsPipelineDBContext dBContext)
        {
            _dbContext = dBContext;
            ResolveRepository(serviceProvider);
        }

        public async Task<List<OptionsResponse>> GetOptionByTypeId(int type)
        {

            List<OptionsResponse> options = new List<OptionsResponse>();

            var dataAgents = _dbContext.AGENTS.ToList();

            var dataAgent = _repoAgent.GetAll().Result;
            var cust = _repoCustomer.GetAllApplyFilters(filter: x => x.Grade == 3, "CustName", false);

            var data = _repository.GetAllApplyFilters(filter: x => x.CountryName == "India" && x.IsDeleted == 0);
            if (type == (int)enumOptionType.entirePipeline)
            {
                // _repository.
                var viewRes = _repoView.GetAll().Result;
                options = (from a in await _repository.GetAll()
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
            _repoView = serviceProvider.GetService<IBaseRepository<testView>>();
            _repository = serviceProvider.GetService<IBaseRepository<MasterCountry>>();
            _repoCustomer = serviceProvider.GetService<IBaseRepository<Customer>>();
            _repoAgent = serviceProvider.GetService<IBaseRepository<AGENTS>>();
        }
    }
}
