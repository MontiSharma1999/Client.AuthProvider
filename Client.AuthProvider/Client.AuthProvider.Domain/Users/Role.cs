namespace Client.AuthProvider.Domain.Users;

public sealed class Role
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public List<Permission> Permissions { get; init; } = new();
}
