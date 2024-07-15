using Callegarin_Giulio.Application.MediatR.Students;
using Callegarin_Giulio.Shared.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Callegarin_Giulio.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : Controller
    {
        private readonly ISender sender;
        public StudentsController(ISender _sender)
        {
            sender = _sender;
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<GetStudentResult>>> GetStudents()
        {
            return Ok(await sender.Send(new GetAllStutentsQuery()));
        }
    }
}
