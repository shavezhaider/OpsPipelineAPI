using System;
using System.Collections.Generic;

#nullable disable

namespace OpsPipelineAPI.Repository.Models
{
    public partial class ErrorLog
    {
        public long ErrorLogId { get; set; }
        public DateTime? ErrorDate { get; set; }
        public string Exception { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Url { get; set; }
        public string Source { get; set; }
        public string Message { get; set; }
        public string InnerMsg { get; set; }
        public string Level { get; set; }
        public bool? IsActive { get; set; }
        public int? UserId { get; set; }
        public int? Line { get; set; }
        public int? Col { get; set; }
    }
}
