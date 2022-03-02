using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using OpsPipelineAPI.Entities.Response;
using OpsPipelineAPI.Entities.Request;

namespace OpsPipelineAPI.Manager.Command.Account
{
    public class ForgotPasswordCommand : IRequest<ForgotPasswordResponse>
    {
        public ForgotPasswordRequest passwordRequest;
        public ForgotPasswordCommand(ForgotPasswordRequest forgotPasswordRequest)
        {
            passwordRequest = forgotPasswordRequest;
        }
    }
}
