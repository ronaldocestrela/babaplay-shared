namespace BabaPlayShared.Library.Models.Requests.Identity;

public class UserRoleRequest
{
    public required string RoleId { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public bool IsAssigned { get; set; }
}

public class UserRolesRequest
{
    public List<UserRoleRequest> UserRoles { get; set; } = [];
}