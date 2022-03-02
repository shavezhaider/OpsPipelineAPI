using Microsoft.AspNetCore.Identity;
using OpsPipelineAPI.Entities.Entity;
using OpsPipelineAPI.Entities.Request;
using OpsPipelineAPI.Entities.Response;
using OpsPipelineAPI.Repository.EDMX;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpsPipelineAPI.Manager.Interface
{
    public interface IUser
    {
        public Task<AppUser> GetUserAuthenticationToken(UserAuthenticationRequest userAuthenticationRequest);
        public Task<AppUserResponse> AddUser(AppUserRequest appUserRequest);
        public Task<ForgotPasswordResponse> ForgotPassword(ForgotPasswordRequest appUserRequest);
        public Task<AppUser> GetUserByEmailAsyn(string email);
        public Task<AppUser> GetUserByUserAsyn(string UserName);
        public Task<AppUser> GetUserByIdAsyn(string Id);
        public Task<ProcessingStatusEntity> ResetPassword(ResetPasswordRequest resetPassword);
        
    }
}

