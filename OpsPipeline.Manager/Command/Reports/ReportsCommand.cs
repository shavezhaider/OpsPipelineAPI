using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using OpsPipelineAPI.Entities.Request;
using OpsPipelineAPI.Entities.Response;

namespace OpsPipelineAPI.Manager.Command.Reports
{
    public class ReportsCommand : IRequest<ReportsResponse>
    {
        ReportsRequest _reportsRequest;
        public ReportsCommand(ReportsRequest reportsRequest)
        {
            _reportsRequest = reportsRequest;
        }
    }
}
