namespace BabaPlayShared.Library.Models.Responses.CheckIns.Response;

public class TeamAssignmentResponse
{
    public DateTime Date { get; set; }

    public List<CheckInResponse> TeamA { get; set; } = [];

    public List<CheckInResponse> TeamB { get; set; } = [];
}
