﻿using System;


namespace OpsPipelineAPI.Entities.Response
{

    public class UserAuthenticationResponse
    {
        public bool IsAuthSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string Token { get; set; }
    }
}