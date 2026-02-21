namespace BabaPlayShared.Library.Models.Requests.Tenancy;

public class UpdateTenantSubscriptionRequest
{
    public required string TenantId { get; set; }
    public DateTime NewExpiryDate { get; set; }
}
