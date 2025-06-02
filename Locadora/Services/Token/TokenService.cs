using Locadora.Dto.User;
using Locadora.Models;

namespace Locadora.Services.Token
{
    public class TokenService : ITokenInterface
    {
        public Task<ResponseModel<List<UserModel>>> GenerateToken(LoginDto loginDto)
        {
            throw new NotImplementedException();
        }
    }
}
