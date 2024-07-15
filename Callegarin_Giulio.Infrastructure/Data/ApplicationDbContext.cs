using Callegarin_Giulio.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Callegarin_Giulio.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }
    public virtual DbSet<Professor> Professors { get; set; }
    public virtual DbSet<Appointment> Appointments { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Student>().HasData(
            new Student() { StudentId = Guid.NewGuid(), FirstName = "Franco", LastName = "Berrucci", BirthDate = new DateOnly(2002, 7, 23), Email = "franco.berrucci@example.com", Phone = "+393492546954", AdditionalNotes = "" },
            new Student() { StudentId = Guid.NewGuid(), FirstName = "Gianpaolo", LastName = "Geppetto", BirthDate = new DateOnly(2001, 4, 16), Email = "gianpaolo.geppetto@example.com", Phone = "+393474526398", AdditionalNotes = "" },
            new Student() { StudentId = Guid.NewGuid(), FirstName = "Stefano", LastName = "Bianchi", BirthDate = new DateOnly(2002, 10, 28), Email = "stefano.bianchi@example.com", Phone = "+393516954821", AdditionalNotes = "" },
            new Student() { StudentId = Guid.NewGuid(), FirstName = "Miriam", LastName = "Rossi", BirthDate = new DateOnly(2003, 1, 8), Email = "miriam.rossi@example.com", Phone = "+393336954712", AdditionalNotes = "" },
            new Student() { StudentId = Guid.NewGuid(), FirstName = "Anna", LastName = "Carducci", BirthDate = new DateOnly(2002, 6, 7), Email = "anna.carducci@example.com", Phone = "+393423698562", AdditionalNotes = "" }
        );

        builder.Entity<Professor>().HasData(
            new Professor() { ProfessorId = Guid.NewGuid(), FirstName = "Stefania", LastName = "Sardi", Specialization = "Math", YearsOfExperience = 7, TeachingAvailability = "Monday,Thursday,Friday", ReceptionAvailability = "Monday,Thursday", PrefersVideo = false },
            new Professor() { ProfessorId = Guid.NewGuid(), FirstName = "Gianpietro", LastName = "Vecchi", Specialization = "English", YearsOfExperience = 3, TeachingAvailability = "Tuesday,Thursday,Friday", ReceptionAvailability = "Tuesday,Friday", PrefersVideo = false },
            new Professor() { ProfessorId = Guid.NewGuid(), FirstName = "Silvia", LastName = "Zuliani", Specialization = "IT", YearsOfExperience = 5, TeachingAvailability = "Wednesday,Saturday", ReceptionAvailability = "Thursday,Friday,Saturday", PrefersVideo = true }
        );
    }
}
