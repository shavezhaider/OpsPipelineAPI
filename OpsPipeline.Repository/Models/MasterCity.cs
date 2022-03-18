using System;
using System.Collections.Generic;

#nullable disable

namespace OpsPipelineAPI.Repository.Models
{
    public partial class MasterCity
    {
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public string CityName { get; set; }
        public string CityCode { get; set; }
        public int IsActive { get; set; }
        public int IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
