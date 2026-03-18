using BabaPlayShared.Library.Enum;

namespace BabaPlayShared.Library.Models.Responses.CheckIns.Response;

public class CheckInResponse
{
    public string Id { get; set; } = string.Empty;

    public string AssociadoId { get; set; } = string.Empty;

    public string FullName { get; set; } = string.Empty;

    public List<SoccerPosition> Positions { get; set; } = [];

    /// <summary>
    /// The arrival position in the list (1 = first a chegar).
    /// </summary>
    public int ArrivalOrder { get; set; }

    /// <summary>
    /// The date (UTC) for which this check-in is valid.
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// The exact UTC time when the check-in was registered.
    /// </summary>
    public DateTime CheckInAtUtc { get; set; }
}
