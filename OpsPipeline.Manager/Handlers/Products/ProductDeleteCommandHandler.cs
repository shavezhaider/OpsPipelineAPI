using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OpsPipelineAPI.Entities.Request;
using OpsPipelineAPI.Entities.Response;
using OpsPipelineAPI.Manager.Interface;
using OpsPipelineAPI.Manager.Command;
using OpsPipelineAPI.Entities.Entity;

namespace OpsPipelineAPI.Manager.Handlers.Products
{
    public class ProductDeleteCommandHandler : IRequestHandler<ProductDeleteCommand, ProcessingStatusEntity>
    {
        private readonly IProductManager _productManager;

        public ProductDeleteCommandHandler(IProductManager productManager)
        {
            _productManager = productManager;


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>

        public Task<ProcessingStatusEntity> Handle(ProductDeleteCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

       




    }
}
