namespace BabaPlayShared.Library.Models.Requests.Associations;

public class CreateAssociationRequest
{
    public required string Name { get; set; }
    public DateTime EstablishedDate { get; set; }
}
