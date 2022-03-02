using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using OpsPipelineAPI.Entities.Entity;
using OpsPipelineAPI.Entities.Request;

namespace OpsPipelineAPI.Manager.Queries
{
    public class ProductListQuery : IRequest<IEnumerable<ProductEntity>>
    {

        public ProductListQuery()
        {

        }

    }
}
