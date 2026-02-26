using BabaPlayShared.Library.Models.Requests.Associados;

namespace BabaPlayShared.Library.Models.Requests.Tenancy;

public class SignupRequest
{
    // Tenant information
    public string? Identifier { get; set; }
    public string? AssociationName { get; set; }

    // Association contact/address (kept in tenant metadata)
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? ZipCode { get; set; }
    public string? PhoneNumber { get; set; }

    // Admin (lead) information — reuse CreateAssociadoRequest
    public CreateAssociadoRequest? Admin { get; set; }
}
