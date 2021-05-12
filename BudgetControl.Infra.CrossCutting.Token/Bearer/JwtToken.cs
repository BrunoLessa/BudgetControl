﻿using System;
using System.IdentityModel.Tokens.Jwt;

namespace BudgetControl.Infra.CrossCutting.Token.Bearer
{
    public class JwtToken
    {
        private JwtSecurityToken _token;

        internal JwtToken(JwtSecurityToken token)
        {
            _token = token;
        }

        public DateTime ValidTo => _token.ValidTo;
        public string Value => new JwtSecurityTokenHandler().WriteToken(_token);
    }
}