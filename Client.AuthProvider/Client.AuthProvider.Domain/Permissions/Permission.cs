using Client.AuthProvider.Domain.Roles;

namespace Client.AuthProvider.Domain.Permissions;

public sealed class Permission
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public ICollection<RolePermission> RolePermissions { get; private set; } = new List<RolePermission>();

    private Permission() { } // For EF Core

    public Permission(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
    }
}
