using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using OpsPipelineAPI.Entities.Response;

namespace OpsPipelineAPI.Manager.Queries
{
    public class SaleBySaleIdQuery :IRequest<SaleResponse>
    {
        public SaleBySaleIdQuery()
        { }
    }
}
