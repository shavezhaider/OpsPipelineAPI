using OpsPipelineAPI.Entities.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpsPipelineAPI.Manager.Interface
{
   public interface IEmailSender
    {
        public bool SendEmail(EmailModalRequest emailModal);
    }
}
