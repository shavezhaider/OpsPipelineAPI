using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using OpsPipelineAPI.Entities.Request;
using OpsPipelineAPI.Entities.Response;

namespace OpsPipelineAPI.Manager.Command.Account
{
    public class AppUserCommand : IRequest<AppUserResponse>
    {
        public AppUserRequest appUserRequest;
        public AppUserCommand(AppUserRequest _appUserRequest)
        {
            appUserRequest = _appUserRequest;
        }
    }
}
