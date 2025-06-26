using Client.AuthProvider.Domain.Permissions;

namespace Client.AuthProvider.Domain.Roles;
public class RolePermission
{
    public Guid RoleId { get; private set; }
    public Guid PermissionId { get; private set; }
    public Role Role { get; private set; }
    public Permission Permission { get; private set; }

    private RolePermission() { } // For EF Core

    public RolePermission(Guid roleId, Guid permissionId)
    {
        RoleId = roleId;
        PermissionId = permissionId;
    }
}