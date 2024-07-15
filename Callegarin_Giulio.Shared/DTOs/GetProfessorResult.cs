namespace Callegarin_Giulio.Shared.DTOs;

public class GetProfessorResult
{
    public Guid ProfessorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Specialization { get; set; }
    public string ReceptionAvailability { get; set; }
    public bool PrefersVideo { get; set; }
}
