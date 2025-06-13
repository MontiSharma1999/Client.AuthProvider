using Client.AuthProvider.Domain.Users;

namespace Client.AuthProvider.Application.Token;

public interface ITokenService
{
    string GenerateToken(User user);
}
