using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Identity;
using OpsPipelineAPI.Entities.Response;
using OpsPipelineAPI.Manager.Command.Account;
using OpsPipelineAPI.Manager.Interface;
using OpsPipelineAPI.Repository.EDMX;

namespace OpsPipelineAPI.Manager.Handlers.Account
{
    public class UserAuthenticationCommandHandler : IRequestHandler<UserAuthenticationCommand, AppUser>
    {
        IUser _user;
        public UserAuthenticationCommandHandler(IUser user)
        {
            _user = user;

        }
        public Task<AppUser> Handle(UserAuthenticationCommand request, CancellationToken cancellationToken)
        {
           return  _user.GetUserAuthenticationToken(request.authenticationRequest);           
        }      


    }
}
