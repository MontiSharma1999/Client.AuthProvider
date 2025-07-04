﻿using Client.AuthProvider.Application.Messaging;
using Client.AuthProvider.Application.Shared;
using Client.AuthProvider.Domain;

namespace Client.AuthProvider.Application.Authenticate;
internal sealed class AuthenticateUserCommandHandler(IJwtTokenGenerator tokenService) : ICommandHandler<AuthenticateUserCommand, Result<string>>
{
    private readonly IJwtTokenGenerator _tokenService = tokenService;
    public Task<Result<Result<string>>> Handle(AuthenticateUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
