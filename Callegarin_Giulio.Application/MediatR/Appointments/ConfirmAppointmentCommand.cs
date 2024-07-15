using Callegarin_Giulio.Infrastructure.Data;
using MediatR;

namespace Callegarin_Giulio.Application.MediatR.Appointments;

public class ConfirmAppointmentCommand : IRequest
{
    public required string AppointmentId { get; init; }
}

internal class ConfirmAppointmentCommandHandler : IRequestHandler<ConfirmAppointmentCommand>
{
    private readonly ApplicationDbContext context;
    public ConfirmAppointmentCommandHandler(ApplicationDbContext _context)
    {
        context = _context;
    }
    public async Task Handle(ConfirmAppointmentCommand request, CancellationToken cancellationToken)
    {
        var appointment = await context.Appointments.FindAsync(new Guid(request.AppointmentId));
        appointment.Confirmed = true;
        await context.SaveChangesAsync();
    }
}
