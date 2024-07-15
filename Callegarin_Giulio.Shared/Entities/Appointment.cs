namespace Callegarin_Giulio.Shared.Entities;

public class Appointment
{
    public Guid AppointmentId { get; set; }
    public Guid StudentId { get; set; }
    public Guid ProfessorId { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }
    public string Description { get; set; }
    public bool Confirmed { get; set; }

    public virtual Student Student { get; set; }
    public virtual Professor Professor { get; set; }
}
