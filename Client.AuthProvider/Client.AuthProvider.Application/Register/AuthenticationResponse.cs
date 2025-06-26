namespace Client.AuthProvider.Application.Register;
public sealed record AuthenticationResponse(string AccessToken, string RefreshToken, DateTime Expires, List<string> Roles);
