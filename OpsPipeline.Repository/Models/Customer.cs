using System;
using System.Collections.Generic;

#nullable disable

namespace OpsPipelineAPI.Repository.Models
{
    public partial class Customer
    {
        public string CustCode { get; set; }
        public string CustName { get; set; }
        public string CustCity { get; set; }
        public string WorkingArea { get; set; }
        public string CustCountry { get; set; }
        public int? Grade { get; set; }
        public int OpeningAmt { get; set; }
        public int ReceiveAmt { get; set; }
        public int PaymentAmt { get; set; }
        public int OutstandingAmt { get; set; }
        public string PhoneNo { get; set; }
        public string AgentCode { get; set; }
    }
}
