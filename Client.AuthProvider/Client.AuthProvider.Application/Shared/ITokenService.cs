using Client.AuthProvider.Domain.Users;

namespace Client.AuthProvider.Application.Shared;

public interface ITokenService
{
    string GenerateToken(User user);
}
