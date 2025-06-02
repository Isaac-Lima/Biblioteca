using Locadora.Dto.User;
using Locadora.Models;

namespace Locadora.Services.Token
{
    public interface ITokenInterface
    {
        Task<ResponseModel<List<UserModel>>> GenerateToken(LoginDto loginDto);
    }
}
