using Client.AuthProvider.Application.Messaging;
using Client.AuthProvider.Domain;

namespace Client.AuthProvider.Application.Authenticate;

public sealed record AuthenticateUserCommand(string Username, string Password) : ICommand<Result<string>>;
