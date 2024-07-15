using Callegarin_Giulio.Infrastructure.Data;
using Callegarin_Giulio.Shared.DTOs;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Callegarin_Giulio.Application.MediatR.Appointments;

public class GetAllAllpointmentsQuery : IRequest<IEnumerable<GetAppointmentResult>>
{
}

internal class GetAllProfessorsQueryHandler : IRequestHandler<GetAllAllpointmentsQuery, IEnumerable<GetAppointmentResult>>
{
    private readonly ApplicationDbContext context;
    public GetAllProfessorsQueryHandler(ApplicationDbContext _context)
    {
        context = _context;
    }
    public async Task<IEnumerable<GetAppointmentResult>> Handle(GetAllAllpointmentsQuery request, CancellationToken cancellationToken)
    {
        var appointments = await context.Appointments.ToListAsync(cancellationToken);
        var result = new List<GetAppointmentResult>();
        foreach (var appointment in appointments)
        {
            var student = await context.Students.FindAsync(appointment.StudentId);
            var professor = await context.Professors.FindAsync(appointment.ProfessorId);
            result.Add(new GetAppointmentResult()
            {
                AppointmentId = appointment.AppointmentId,
                StudentName = student.FirstName + " " + student.LastName,
                ProfessorName = professor.FirstName + " " + professor.LastName,
                Date = appointment.Date,
                Time = appointment.Time,
                Description = appointment.Description,
                Confirmed = appointment.Confirmed
            });
        }
        return result;
    }
}
