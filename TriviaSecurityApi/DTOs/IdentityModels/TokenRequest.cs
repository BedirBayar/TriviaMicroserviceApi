﻿namespace TriviaSecurityApi.DTOs.IdentityModels
{
    public class TokenRequest
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
