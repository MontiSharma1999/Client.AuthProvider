namespace Client.AuthProvider.Application.Shared;

public interface IJwtTokenGenerator
{
    (string Token, long ExpiresIn) GenerateToken(Guid userId, string name, string email, List<string> role);
}
