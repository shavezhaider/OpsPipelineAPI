using System;
using System.Collections.Generic;
using System.Text;

namespace OpsPipelineAPI.Utilities
{
    public static class Enums
    {
        public enum statusCode
        {
            Success = 1,
            Failure = 2,
            Incomplete = 3,
            Error = 4,
            DuplicateRecord = 5

        }
        public enum Role
        {
            SuperAdmin,
            Admin,
            Employee,
            Customer
        }

        public enum enumOptionType
        {
            entirePipeline = 1,
            dealLocation = 2,
            SalesStage = 3,
            topDeal = 4
        }


    }
}
