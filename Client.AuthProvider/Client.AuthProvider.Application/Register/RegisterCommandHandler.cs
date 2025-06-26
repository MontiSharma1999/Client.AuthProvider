using Client.AuthProvider.Application.Messaging;
using Client.AuthProvider.Domain;

namespace Client.AuthProvider.Application.Register;
internal sealed class RegisterCommandHandler : ICommandHandler<RegisterCommand, AuthenticationResponse>
{
    public Task<Result<AuthenticationResponse>> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
