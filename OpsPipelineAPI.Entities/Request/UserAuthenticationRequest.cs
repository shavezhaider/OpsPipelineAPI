using System;
using System.ComponentModel.DataAnnotations;
using MediatR;
using OpsPipelineAPI.Entities.Response;

namespace OpsPipelineAPI.Entities.Request
{
	/// <summary>
	/// Summary description for Class1
	/// </summary>
	public class UserAuthenticationRequest :IRequest<UserAuthenticationResponse>
	{

		//
		// TODO: Add constructor logic here
		//
		[Required(ErrorMessage = "Email is required.")]
		public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required.")]
		public string Password { get; set; }

	}
}