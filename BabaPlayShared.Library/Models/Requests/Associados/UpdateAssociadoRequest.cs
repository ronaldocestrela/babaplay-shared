using System;

namespace BabaPlayShared.Library.Models.Requests.Associados;

public class UpdateAssociadoRequest
{
    public string? FullName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? ZipCode { get; set; }
    public string? Position { get; set; }
}
