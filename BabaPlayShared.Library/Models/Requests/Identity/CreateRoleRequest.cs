namespace BabaPlayShared.Library.Models.Requests.Identity;
public class CreateRoleRequest
{
    public required string Name { get; set; }
    public string? Description { get; set; }
}