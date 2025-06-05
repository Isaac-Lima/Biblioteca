using Locadora.Dto.Autor;
using Locadora.Services.Token;
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
        public async Task<ActionResult<string>> Login(LoginAutorDto loginAutorDto)
        {
            var token = await tokenInterface.GenerateToken(loginAutorDto);

            if (string.IsNullOrEmpty(token.Dados))
            {
                return Unauthorized("Usuário ou senha inválidos.");
            }

            return Ok(token.Dados);
        }
    }
}
