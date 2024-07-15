namespace Callegarin_Giulio.Shared.DTOs;

public class CreateAppintentRequest
{
    public Guid StudentId { get; set; }
    public Guid ProfessorId { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }
    public string Description { get; set; }
}
