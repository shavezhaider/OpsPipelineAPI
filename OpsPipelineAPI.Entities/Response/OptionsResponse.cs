using OpsPipelineAPI.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpsPipelineAPI.Entities.Response
{
    public class OptionsResponse
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public ProcessingStatusEntity processingStatus { get; set; }
    }
}
