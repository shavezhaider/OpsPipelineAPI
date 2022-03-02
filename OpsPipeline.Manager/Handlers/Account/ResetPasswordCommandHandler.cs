using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OpsPipelineAPI.Entities.Entity;
using OpsPipelineAPI.Manager.Command.Account;
using OpsPipelineAPI.Manager.Interface;

namespace OpsPipelineAPI.Manager.Handlers.Account
{
    public class ResetPasswordCommandHandler : IRequestHandler<ResetPasswordCommand, ProcessingStatusEntity>
    {
        public IUser _userManger;
        public ResetPasswordCommandHandler(IUser userManager)
        {
            _userManger = userManager;
        }
        public Task<ProcessingStatusEntity> Handle(ResetPasswordCommand request, CancellationToken cancellationToken)
        {
            return _userManger.ResetPassword(request.resetPassword);
        }
    }
}
