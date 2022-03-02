using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using OpsPipelineAPI.Entities.Response;

namespace OpsPipelineAPI.Manager.Queries
{
    public class SalesListQuery : IRequest<IEnumerable<SaleResponse>>
    {
        public SalesListQuery()
        {

        }
    }
}
