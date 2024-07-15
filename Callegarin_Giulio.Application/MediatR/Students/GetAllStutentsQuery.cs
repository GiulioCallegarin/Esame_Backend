using Callegarin_Giulio.Infrastructure.Data;
using Callegarin_Giulio.Shared.DTOs;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Callegarin_Giulio.Application.MediatR.Students;

public class GetAllStutentsQuery : IRequest<IEnumerable<GetStudentResult>>
{
}
internal class GetAllStudentsQueryHandler : IRequestHandler<GetAllStutentsQuery, IEnumerable<GetStudentResult>>
{
    private readonly ApplicationDbContext context;
    public GetAllStudentsQueryHandler(ApplicationDbContext _context)
    {
        context = _context;
    }
    public async Task<IEnumerable<GetStudentResult>> Handle(GetAllStutentsQuery request, CancellationToken cancellationToken)
    {
        var students = await context.Students.ToListAsync(cancellationToken);
        var result = students.Select(student =>
            new GetStudentResult() { StudentId = student.StudentId, FirstName = student.FirstName, LastName = student.LastName }
        );
        return result;
    }
}
