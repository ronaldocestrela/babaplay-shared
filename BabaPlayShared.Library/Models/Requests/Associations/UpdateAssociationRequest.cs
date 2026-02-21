namespace BabaPlayShared.Library.Models.Requests.Associations;

public class UpdateAssociationRequest
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public DateTime EstablishedDate { get; set; }
}
