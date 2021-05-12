using BudgetControl.Infra.CrossCutting.Token.Bearer;
using BugetControl.Application.DTO.DTOs;
using BugetControl.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Threading.Tasks;

namespace BudgetWebAPI.Controllers
{
    public class TokenController : Controller
    {
        private readonly IConfiguration _config;
        private readonly IApplicationServiceUsuario _applicationUsuario;
        public TokenController(IConfiguration config , IApplicationServiceUsuario applicationUsuario)
        {
            _config = config;
            _applicationUsuario = applicationUsuario;
        }

        [AllowAnonymous]
        [Produces("application/json")]
        [HttpPost("api/CreateToken")]
        public async Task<IActionResult> CreateToken([FromBody] UsuarioDTO usuarioDTO)
        {
            if (string.IsNullOrWhiteSpace(usuarioDTO.Login) || string.IsNullOrWhiteSpace(usuarioDTO.PassWord))
                return Unauthorized();

            var result = await _applicationUsuario.ObterParaLogin(usuarioDTO);
            if (result == null || !result.Id.HasValue || !result.Ativo)
                return Unauthorized();

            return Ok(new { token = GerarTokenJwt(result) });
        }
        public string GerarTokenJwt(UsuarioDTO usuario)
        {
            var token = new JwtTokenBuilder();
            token.AddIssuer(_config["Jwt:Issuer"]);
            token.AddAudience(_config["Jwt:Audience"]);
            var securityKey = new SymmetricSecurityKey
                         (Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            token.AddSecurityKey(securityKey);
            token.AddSubject(usuario.Nome);
            token.AddClaim("role", usuario.Role.ToString());
            var tokenHandler = token.Builder();
            return tokenHandler.Value;
            
        }
    }
}