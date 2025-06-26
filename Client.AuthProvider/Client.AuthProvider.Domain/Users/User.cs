using Client.AuthProvider.Domain.Token;

namespace Client.AuthProvider.Domain.Users;
public sealed class User
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string PasswordHash { get; private set; }
    public string? ProfileUrl { get; private set; }
    public ICollection<UserRole> UserRoles { get; private set; } = new List<UserRole>();
    public RefreshToken? RefreshToken { get; private set; }

    private User() { } // For EF Core

    public User(string name, string email, string passwordHash, string? profileUrl = null)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        PasswordHash = passwordHash;
        ProfileUrl = profileUrl;
    }

    public void AddRole(Guid roleId)
    {
        UserRoles.Add(new UserRole(Id, roleId));
    }

    public void UpdateRefreshToken(string token, DateTime expires, DateTime created)
    {
        RefreshToken = new RefreshToken(token, expires, created);
    }
}
