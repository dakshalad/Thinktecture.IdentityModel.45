﻿using System.IdentityModel.Tokens;

namespace Thinktecture.IdentityModel.Tokens
{
    public class WebTokenSecurityKeyClause : SecurityKeyIdentifierClause
    {
        public string Issuer { get; set; }

        public WebTokenSecurityKeyClause(string issuer)
            : base("WebToken")
        {
            Issuer = issuer;
        }
    }
}
