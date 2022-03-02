using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using OpsPipelineAPI.Entities.Entity;
using OpsPipelineAPI.Entities.Request;

namespace OpsPipelineAPI.Manager.Command.Account
{
   public class ResetPasswordCommand : IRequest<ProcessingStatusEntity>
    {
        public ResetPasswordRequest resetPassword;
        public ResetPasswordCommand(ResetPasswordRequest resetPasswordRequest)
        {
            resetPassword = resetPasswordRequest;
        }
    }
}
