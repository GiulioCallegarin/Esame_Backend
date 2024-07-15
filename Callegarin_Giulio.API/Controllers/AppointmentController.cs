using Callegarin_Giulio.Application.MediatR.Appointments;
using Callegarin_Giulio.Shared.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Callegarin_Giulio.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppointmentController : Controller
    {
        private readonly ISender sender;
        public AppointmentController(ISender _sender)
        {
            sender = _sender;
        }
        [HttpPost("")]
        public async Task<ActionResult> CreateAppointment(CreateAppintentRequest appointment)
        {
            var result = await sender.Send(new CreateAppointmentCommand()
            {
                StudentId = appointment.StudentId,
                ProfessorId = appointment.ProfessorId,
                Date = appointment.Date,
                Time = appointment.Time,
                Description = appointment.Description
            });
            if (result) return Ok();
            return BadRequest();
        }

        [HttpPost("Confirm")]
        public async Task<ActionResult> ConfirmAppointment(string appointmentId)
        {
            await sender.Send(new ConfirmAppointmentCommand() { AppointmentId = appointmentId });
            return Ok();
        }
    }
}
