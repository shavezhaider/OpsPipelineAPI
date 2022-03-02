using MediatR;
using OpsPipelineAPI.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpsPipelineAPI.Manager.Queries
{
   public class ProductByProductIdQuery :IRequest<ProductEntity>
    {
        public int id { get; }

        public ProductByProductIdQuery(int Id)
        {
            id = Id;
        }
    }
}
