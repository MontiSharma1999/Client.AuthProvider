using Client.AuthProvider.Application.Messaging;

namespace Client.AuthProvider.Application.Register;
public sealed record RegisterCommand(string Name, string Email, string Password, string? ProfileUrl = null) : ICommand<AuthenticationResponse>;
