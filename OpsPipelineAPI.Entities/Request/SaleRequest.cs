using OpsPipelineAPI.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using OpsPipelineAPI.Entities.Response;

namespace OpsPipelineAPI.Entities.Request
{
   public class SaleRequest :IRequest<SaleResponse>
    { 
        public SalesMasterEntity salesMasterEntity { get; set; }
    }
}
