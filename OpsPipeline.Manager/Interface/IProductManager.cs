
using OpsPipelineAPI.Entities.Entity;
using OpsPipelineAPI.Entities.Request;
using OpsPipelineAPI.Entities.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpsPipelineAPI.Manager.Interface
{
    public interface IProductManager
    {
        //Task<  void GetProductList();
        /// <summary>
        /// 
        /// </summary>
        Task<ProductResponse> AddProductAsync(ProductRequest productRequest);
        Task<ProcessingStatusEntity> DeleteProductAsync(int productId);
        Task<IEnumerable<ProductEntity>> GetProductList();
        Task<ProductEntity> GetProductByProductId(int productId);
    }
}
