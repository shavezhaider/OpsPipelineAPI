using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OpsPipelineAPI.Entities.Entity;
using OpsPipelineAPI.Manager.Interface;
using OpsPipelineAPI.Manager.Queries;

namespace OpsPipelineAPI.Manager.Handlers.Products
{
    public class ProductListQueryHandler : IRequestHandler<ProductListQuery, IEnumerable<ProductEntity>>
    {
        private readonly IProductManager _IproductManager;

        public ProductListQueryHandler(IProductManager productManager)
        {
            _IproductManager = productManager;
        }
        public async  Task<IEnumerable<ProductEntity>> Handle(ProductListQuery request, CancellationToken cancellationToken)
        {
            return await _IproductManager.GetProductList();
        }
    }
}
