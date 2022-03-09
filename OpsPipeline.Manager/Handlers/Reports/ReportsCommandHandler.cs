using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OpsPipelineAPI.Entities.Response;
using OpsPipelineAPI.Manager.Command.Reports;

namespace OpsPipelineAPI.Manager.Handlers.Reports
{
    public class ReportsCommandHandler : IRequestHandler<ReportsCommand, ReportsResponse>
    {
        public Task<ReportsResponse> Handle(ReportsCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
