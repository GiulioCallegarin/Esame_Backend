using System.ComponentModel.DataAnnotations;

namespace Callegarin_Giulio.Shared.Entities;

public class Professor
{
    public Guid ProfessorId { get; set; }
    [MaxLength(64)]
    public string FirstName { get; set; }
    [MaxLength(64)]
    public string LastName { get; set; }
    [MaxLength(32)]
    public string Specialization { get; set; }
    public int YearsOfExperience { get; set; }
    [MaxLength(64)]
    public string TeachingAvailability { get; set; }
    [MaxLength(64)]
    public string ReceptionAvailability { get; set; }
    public bool PrefersVideo { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; }

}
