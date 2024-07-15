using Callegarin_Giulio.Infrastructure.Data;
using Callegarin_Giulio.Shared.Entities;
using MediatR;

namespace Callegarin_Giulio.Application.MediatR.Appointments;

public class CreateAppointmentCommand : IRequest<bool>
{
    public required Guid StudentId { get; init; }
    public required Guid ProfessorId { get; init; }
    public required DateOnly Date { get; init; }
    public required TimeOnly Time { get; init; }
    public required string Description { get; init; }
}

internal class CreateAppintmentCommandHandler : IRequestHandler<CreateAppointmentCommand, bool>
{
    private readonly ApplicationDbContext context;
    public CreateAppintmentCommandHandler(ApplicationDbContext _context)
    {
        context = _context;
    }
    public async Task<bool> Handle(CreateAppointmentCommand request, CancellationToken cancellationToken)
    {
        var professor = await context.Professors.FindAsync(request.ProfessorId, cancellationToken);
        var availableDays = professor?.ReceptionAvailability.Split(',').Select(day => day.ToLower());
        if (availableDays != null && availableDays.Contains(request.Date.DayOfWeek.ToString().ToLower()))
        {
            await context.Appointments.AddAsync(new Appointment()
            {
                AppointmentId = Guid.NewGuid(),
                StudentId = request.StudentId,
                ProfessorId = request.ProfessorId,
                Description = request.Description,
                Date = request.Date,
                Time = request.Time,
                Confirmed = false
            });
            await context.SaveChangesAsync();
            return true;
        }
        return false;
    }
}
