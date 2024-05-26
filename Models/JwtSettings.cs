﻿namespace jwt_authentication_api.Models
{
    public class JwtSettings
    {
        public required string Secret { get; set; }
        public required int ExpirationHours { get; set; }
        public required string Issuer { get; set; }
        public required string Audience { get; set; }
    }
}