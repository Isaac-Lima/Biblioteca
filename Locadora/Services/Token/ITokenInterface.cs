using Locadora.Dto.Autor;
using Locadora.Models;

namespace Locadora.Services.Token
{
    public interface ITokenInterface
    {
        Task<ResponseModel<string>> GenerateToken(LoginAutorDto loginAutorDto);
    }
}
