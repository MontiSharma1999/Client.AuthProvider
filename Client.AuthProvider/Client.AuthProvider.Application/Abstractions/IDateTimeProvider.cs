namespace Client.AuthProvider.Application.Abstractions;
public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}
