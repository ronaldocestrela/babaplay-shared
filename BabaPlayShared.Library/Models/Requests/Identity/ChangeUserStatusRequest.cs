namespace BabaPlayShared.Library.Models.Requests.Identity;

public class ChangeUserStatusRequest
{
    public required string UserId { get; set; }
    public bool Activation { get; set; }
}
