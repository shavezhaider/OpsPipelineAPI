using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OpsPipelineAPI.Entities.Response;
using OpsPipelineAPI.Manager.Interface;
using OpsPipelineAPI.Manager.Queries;

namespace OpsPipelineAPI.Manager.Handlers
{
    public class OptionsQueryHandler : IRequestHandler<OptionsQuery, List<OptionsResponse>>
    {
        public IOptionsSelect _optionsSelect;
        public OptionsQueryHandler(IOptionsSelect optionsSelect)
        {
            _optionsSelect = optionsSelect;
        }
        public async Task<List<OptionsResponse>> Handle(OptionsQuery request, CancellationToken cancellationToken)
        {
            return await _optionsSelect.GetOptionByTypeId(request.type);

        }
    }
}
