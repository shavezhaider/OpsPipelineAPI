
using MediatR;
using OpsPipelineAPI.Entities.Response;
using System.Collections.Generic;

namespace OpsPipelineAPI.Manager.Queries
{
    public class OptionsQuery : IRequest<List<OptionsResponse>>
    {
        public int type { get; set; }
        public OptionsQuery(int _type)
        {
            type = _type;
        }
    }
}
