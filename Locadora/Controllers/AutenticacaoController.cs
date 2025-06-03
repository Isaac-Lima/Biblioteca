using Locadora.Dto.User;
using Locadora.Services.Token;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Locadora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacaoController : ControllerBase
    {
        private readonly ITokenInterface tokenInterface;

        public AutenticacaoController(ITokenInterface tokenInterface)
        {
            this.tokenInterface = tokenInterface;
        }

        [HttpPost("Login")]
        public async Task<ActionResult<string>> Login(LoginDto loginDto)
        {
            var token = await tokenInterface.GenerateToken(loginDto);

            if (string.IsNullOrEmpty(token.Dados))
            {
                return Unauthorized("Usuário ou senha inválidos.");
            }

            return Ok(token.Dados);
        }
    }
}
