using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using OpsPipelineAPI.Entities.Entity;
using OpsPipelineAPI.Entities.Request;
using OpsPipelineAPI.Entities.Response;

namespace OpsPipelineAPI.Manager.Command
{
    public class CreateSaleCommand : IRequest<ProcessingStatusEntity>
    {
        public SaleRequest saleRequest;
        public CreateSaleCommand(SaleRequest _saleRequest)
        {
            saleRequest = _saleRequest;

        }
    }
}
