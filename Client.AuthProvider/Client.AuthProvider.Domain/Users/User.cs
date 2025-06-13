namespace Client.AuthProvider.Domain.Users;
public sealed class User
{
    private readonly List<Role> _roles = new();
    public Guid Id { get; private set; }
    public string Username { get; private set; }
    public string PasswordHash { get; private set; }
    public IReadOnlyCollection<Role> Roles => _roles.ToList();
}
