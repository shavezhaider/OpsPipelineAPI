using OpsPipelineAPI.Repository.EDMX;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpsPipelineAPI.Manager.Interface
{
   public interface ISetting
    {
        Setting GetSettingByName(string Name);
    }
}
