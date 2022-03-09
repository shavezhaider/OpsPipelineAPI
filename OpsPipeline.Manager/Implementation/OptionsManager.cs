using Microsoft.Extensions.Options;
using OpsPipelineAPI.Entities.Response;
using OpsPipelineAPI.Manager.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static OpsPipelineAPI.Utilities.Enums;

namespace OpsPipelineAPI.Manager.Implementation
{
    public class OptionsManager : IOptionsSelect
    {
        public Task<List<OptionsResponse>> GetOptionByTypeId(int type)
        {
            
            if (type == (int)enumOptionType.entirePipeline)
            {

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

            throw new NotImplementedException();
        }
    }
}
