using BarberShop.Core.Interfaces.Services;
using BarberShop.Core.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace BarberShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendamentoController : ControllerBase
    {
        private readonly IAgendamentoService _service;

        public AgendamentoController(IAgendamentoService service)
        {
            _service = service;
        }

        [HttpPost]
        public Task<AgendamentoResponse> Agendamento([FromForm]AgendamentoRequest agendamento)
        {
            return _service.Agendamento(agendamento);
        }
    }
}
