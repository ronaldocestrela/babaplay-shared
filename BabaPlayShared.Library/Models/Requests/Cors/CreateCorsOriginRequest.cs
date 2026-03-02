namespace BabaPlayShared.Library.Models.Requests.Cors;
public record CreateCorsOriginRequest
{
    public string? Origin { get; set; }
}