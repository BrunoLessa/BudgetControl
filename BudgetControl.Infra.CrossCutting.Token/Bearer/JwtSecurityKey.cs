﻿using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace BudgetControl.Infra.CrossCutting.Token.Bearer
{
    public static class JwtSecurityKey
    {
        public static SymmetricSecurityKey Create(string secret)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));
        }
    }
}