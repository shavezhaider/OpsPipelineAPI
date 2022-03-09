using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using OpsPipelineAPI.Entities.Response;

namespace OpsPipelineAPI.Manager.Command.Reports
{
    public class ReportsCommand : IRequest<ReportsResponse>
    {
    }
}
