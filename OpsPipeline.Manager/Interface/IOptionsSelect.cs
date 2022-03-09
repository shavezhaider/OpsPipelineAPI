using OpsPipelineAPI.Entities.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpsPipelineAPI.Manager.Interface
{
    public interface IOptionsSelect
    {
        Task<List<OptionsResponse>>  GetOptionByTypeId(int type);
    }
}
