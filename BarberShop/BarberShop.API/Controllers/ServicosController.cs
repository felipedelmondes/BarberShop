using BarberShop.Core.Interfaces.Services;
using BarberShop.Core.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BarberShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicosController : ControllerBase
    {
        private readonly IServicosService _servicos;

        public ServicosController(IServicosService servicos)
        {
            _servicos = servicos;
        }

        [HttpGet]
        public List<ServicosViewModel> GetServicos() 
        { 
            return _servicos.GetServicos();
        }

    }
}
