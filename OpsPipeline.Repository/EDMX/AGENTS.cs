using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OpsPipelineAPI.Repository.EDMX
{
    public class AGENTS
    {
        [Key]
        public string AGENT_CODE { get; set; }
        public string AGENT_NAME { get; set; }
        public string WORKING_AREA { get; set; }
        public decimal? COMMISSION { get; set; }
        public string PHONE_NO { get; set; }
        public string COUNTRY { get; set; }

    }
}
