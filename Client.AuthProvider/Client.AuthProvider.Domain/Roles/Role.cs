using Client.AuthProvider.Domain.Users;

namespace Client.AuthProvider.Domain.Roles;
public sealed class Role
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public ICollection<RolePermission> RolePermissions { get; private set; } = new List<RolePermission>();
    public ICollection<UserRole> UserRoles { get; private set; } = new List<UserRole>();

    private Role() { } // For EF Core

    public Role(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
    }

    public void AddPermission(Guid permissionId)
    {
        RolePermissions.Add(new RolePermission(Id, permissionId));
    }
}
