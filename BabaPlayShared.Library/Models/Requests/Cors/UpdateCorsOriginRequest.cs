namespace BabaPlayShared.Library.Models.Requests.Cors;

public class UpdateCorsOriginRequest
{
    public string? Origin { get; set; }
    public bool IsActive { get; set; }
}
