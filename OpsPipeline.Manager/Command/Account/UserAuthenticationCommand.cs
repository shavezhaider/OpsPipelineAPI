using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using Microsoft.AspNetCore.Identity;
using OpsPipelineAPI.Entities.Request;
using OpsPipelineAPI.Entities.Response;
using OpsPipelineAPI.Repository.EDMX;

namespace OpsPipelineAPI.Manager.Command.Account
{
   public class UserAuthenticationCommand : IRequest<AppUser>
    {
        public UserAuthenticationRequest authenticationRequest;
        public UserAuthenticationCommand(UserAuthenticationRequest userAuthenticationRequest)
        {
            authenticationRequest = userAuthenticationRequest;
        }

    }
}
