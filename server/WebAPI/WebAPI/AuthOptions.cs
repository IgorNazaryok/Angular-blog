﻿using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace WebAPI
{
    public class AuthOptions
    {
        public const string ISSUER = "BlogServer"; 
        public const string AUDIENCE = "BlogClient"; 
        const string KEY = "mysupersecret_secretkey!123";
        public const int LIFETIME = 20;
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
