namespace Callegarin_Giulio.Shared.DTOs;

public class GetAppointmentResult
{
    public Guid AppointmentId { get; set; }
    public string StudentName { get; set; }
    public string ProfessorName { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }
    public string Description { get; set; }
    public bool Confirmed { get; set; }
}
