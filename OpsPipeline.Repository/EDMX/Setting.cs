using System;
using System.Collections.Generic;

#nullable disable

namespace OpsPipelineAPI.Repository.EDMX
{
    public partial class Setting
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public int? IntValue { get; set; }
        public bool? BoolValue { get; set; }
        public bool? Status { get; set; }
    }
}
