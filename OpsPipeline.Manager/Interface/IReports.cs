using OpsPipelineAPI.Entities.Request;
using OpsPipelineAPI.Entities.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpsPipelineAPI.Manager.Interface
{
    public interface IReports
    {
        Task<List<ReportsResponse>> GetReport(ReportsRequest reportsRequest);
    }
}
