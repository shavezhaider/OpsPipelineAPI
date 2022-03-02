using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using MediatR;
using OpsPipelineAPI.Entities.Response;

namespace OpsPipelineAPI.Entities.Request
{
    public class ForgotPasswordRequest : IRequest<ForgotPasswordResponse>
    {
        [Required]
        
        public string UserName { get; set; }
    }
}
