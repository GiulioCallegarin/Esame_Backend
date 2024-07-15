using Callegarin_Giulio.Infrastructure.Data;
using Callegarin_Giulio.Shared.DTOs;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Callegarin_Giulio.Application.MediatR.Professors;

public class GetAllProfessorsQuery : IRequest<IEnumerable<GetProfessorResult>>
{
}

internal class GetAllProfessorsQueryHandler : IRequestHandler<GetAllProfessorsQuery, IEnumerable<GetProfessorResult>>
{
    private readonly ApplicationDbContext context;
    public GetAllProfessorsQueryHandler(ApplicationDbContext _context)
    {
        context = _context;
    }
    public async Task<IEnumerable<GetProfessorResult>> Handle(GetAllProfessorsQuery request, CancellationToken cancellationToken)
    {
        var professors = await context.Professors.ToListAsync(cancellationToken);
        var result = professors.Select(professor => new GetProfessorResult()
        {
            ProfessorId = professor.ProfessorId,
            FirstName = professor.FirstName,
            LastName = professor.LastName,
            Specialization = professor.Specialization,
            ReceptionAvailability = professor.ReceptionAvailability,
            PrefersVideo = professor.PrefersVideo
        }
        );
        return result;
    }
}
