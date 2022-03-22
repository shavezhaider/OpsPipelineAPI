using OpsPipelineAPI.Entities.Request;
using OpsPipelineAPI.Entities.Response;
using OpsPipelineAPI.Manager.Interface;
using OpsPipelineAPI.Repository.EDMX;
using OpsPipelineAPI.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsPipelineAPI.Manager.Implementation
{
    public class ReportsManager : IReports
    {
        ReportContext _dbContext;
        public ReportsManager(ReportContext dbContext)
        {
            _dbContext=dbContext;
        }
        public Task<List<ReportsResponse>> GetReport(ReportsRequest reportsRequest)
        {
            // _dbContext.Database.("CreateStudents @p0, @p1", parameters: new[] { "Bill", "Gates" });
          
          // _dbContext.Database.ExecuteSqlCommand()
            throw new NotImplementedException();
        }
    }
}
