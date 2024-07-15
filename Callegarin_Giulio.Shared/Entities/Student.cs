using System.ComponentModel.DataAnnotations;

namespace Callegarin_Giulio.Shared.Entities;

public class Student
{
    public Guid StudentId { get; set; }
    [MaxLength(64)]
    public string FirstName { get; set; }
    [MaxLength(64)]
    public string LastName { get; set; }
    public DateOnly BirthDate { get; set; }
    [MaxLength(64)]
    public string Email { get; set; }
    [MaxLength(16)]
    public string Phone { get; set; }
    public string AdditionalNotes { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; }
}
