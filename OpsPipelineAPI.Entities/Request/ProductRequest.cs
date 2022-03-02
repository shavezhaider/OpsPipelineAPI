using MediatR;
using OpsPipelineAPI.Entities.Entity;
using OpsPipelineAPI.Entities.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsPipelineAPI.Entities.Request
{
    public class ProductRequest : IRequest<ProductResponse>
    {
        public ProductEntity productEntity { get; set; }
    }
}
