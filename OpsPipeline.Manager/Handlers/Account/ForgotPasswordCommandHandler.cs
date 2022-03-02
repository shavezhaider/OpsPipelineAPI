using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OpsPipelineAPI.Entities.Response;
using OpsPipelineAPI.Manager.Command.Account;
using OpsPipelineAPI.Manager.Interface;

namespace OpsPipelineAPI.Manager.Handlers.Account
{
    public class ForgotPasswordCommandHandler : IRequestHandler<ForgotPasswordCommand, ForgotPasswordResponse>
    {
        public IUser _userManger;
        public ForgotPasswordCommandHandler(IUser userManager)
        {
            _userManger = userManager;
        }
        public Task<ForgotPasswordResponse> Handle(ForgotPasswordCommand request, CancellationToken cancellationToken)
        {
            return _userManger.ForgotPassword(request.passwordRequest);
        }
    }
}
