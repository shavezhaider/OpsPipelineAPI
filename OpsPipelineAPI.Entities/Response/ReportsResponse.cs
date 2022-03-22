using OpsPipelineAPI.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpsPipelineAPI.Entities.Response
{
    public class ReportsResponse
    {
        public List<Reportlist> Reportlist { get; set; }
        public int? totalRecords { get; set; }
        public ProcessingStatusEntity processingStatus { get; set; }
    }
    public class Reportlist
    {
        public string name { get; set; }
    }
}
