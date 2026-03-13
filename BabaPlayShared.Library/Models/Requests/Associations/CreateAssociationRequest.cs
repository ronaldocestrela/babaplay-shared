namespace BabaPlayShared.Library.Models.Requests.Associations;

public class CreateAssociationRequest
{
    public string? Name { get; set; }
    public DateTime? EstablishedDate { get; set; }
    public string? Statute { get; set; }
    public string? LogoUrl { get; set; }
}
