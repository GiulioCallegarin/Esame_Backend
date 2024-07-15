using Callegarin_Giulio.Application.MediatR.Professors;
using Callegarin_Giulio.Shared.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Callegarin_Giulio.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfessorsController : Controller
    {
        private readonly ISender sender;
        public ProfessorsController(ISender _sender)
        {
            sender = _sender;
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<GetProfessorResult>>> GetProfessors()
        {
            return Ok(await sender.Send(new GetAllProfessorsQuery()));
        }
    }
}
