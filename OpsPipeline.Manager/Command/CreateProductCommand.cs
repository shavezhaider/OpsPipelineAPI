using MediatR;
using OpsPipelineAPI.Entities.Request;
using OpsPipelineAPI.Entities.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsPipelineAPI.Manager.Command
{
    public class CreateProductCommand : IRequest<ProductResponse>
    {
        public ProductRequest ProductRequest;

        public CreateProductCommand(ProductRequest productRequest)
        {
            ProductRequest = productRequest;
        }
    }
}
