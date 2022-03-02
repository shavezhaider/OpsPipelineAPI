﻿using OpsPipelineAPI.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpsPipelineAPI.Manager.Interface
{
    public interface  IPurchase
    {
        Task<ProcessingStatusEntity> AddPurchase();
        Task<ProcessingStatusEntity> GetAllPurchase();
        Task<ProcessingStatusEntity> GetPurchaseByPurchaseID();
        Task<ProcessingStatusEntity> GetPurchaseByCustomerID();
    }
}
