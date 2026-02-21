namespace BabaPlayShared.Library.Models.Requests.Identity;

public class ChangePasswordRequest
{
    public required string UserId { get; set; }
    public required string CurrentPassword { get; set; }
    public required string NewPassword { get; set; }
    public required string ConfirmNewPassword { get; set; }
}
