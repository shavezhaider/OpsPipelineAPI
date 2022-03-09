using System;
using System.Collections.Generic;
using System.Text;

namespace OpsPipelineAPI.Entities.Request
{
    public class ReportsRequest
    {
        public int entirePipeline { get; set; }
        public int dealLocation { get; set; }
        public int SalesStage { get; set; }
        public int topDeal { get; set; }
    }
}
