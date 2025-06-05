using Locadora.Data;
using Locadora.Dto.Autor;
using Locadora.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Locadora.Services.Token
{
    public class TokenService : ITokenInterface
    {
        private readonly IConfiguration _configuration;
        private readonly AppDbContext _context;

        public TokenService(IConfiguration configuration, AppDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }

        public async Task<ResponseModel<string>> GenerateToken(LoginAutorDto loginAutorDto)
        {
            ResponseModel<string> resposta = new ResponseModel<string>();

            try
            {
                var usuario = await _context.Autores.FirstOrDefaultAsync(autorDb => autorDb.Nome == loginAutorDto.Nome);

                if (usuario == null || !BCrypt.Net.BCrypt.Verify(loginAutorDto.Senha, usuario.Senha))
                {
                    resposta.Mensagem = "Usuário ou senha inválidos !";
                    resposta.Status = false;
                    return resposta;
                }

                var chaveSecreta = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"] ?? string.Empty));
                var emissor = _configuration["Jwt:Issuer"];
                var destinatario = _configuration["Jwt:Audience"];

                var credenciaisLogin = new SigningCredentials(chaveSecreta, SecurityAlgorithms.HmacSha256);

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, usuario.Nome),
                };

                claims.AddRange(usuario.Role.Select(role => new Claim(ClaimTypes.Role, usuario.Role)));

                var tokenOptions = new JwtSecurityToken(
                    issuer: emissor,
                    audience: destinatario,
                    claims: claims,
                    expires: DateTime.Now.AddHours(2),
                    signingCredentials: credenciaisLogin
                );

                var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

                resposta.Mensagem = "Login realizado com sucesso !";
                resposta.Dados = token;

                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Mensagem = ex.Message;
                resposta.Status = false;
                return resposta;
            }
            
        }
    }
}
