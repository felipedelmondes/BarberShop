using BarberShop.Core.Interfaces.Services;
using BarberShop.Core.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BarberShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {
        private readonly IFuncionariosServices _service;

        public FuncionariosController(IFuncionariosServices service)
        {
            _service = service;
        }

        [HttpGet]
        public List<FuncionarioViewModel> GetFuncionarios()
        {
            return _service.GetFuncionarios();
        }
    }
}
