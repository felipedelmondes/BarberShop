using BarberShop.Core.Interfaces.Services;
using BarberShop.Core.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BarberShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClientesServices _clientesService;

        public ClientesController(IClientesServices clientesService)
        {
            _clientesService = clientesService;
        }

        [HttpGet]
        public List<ClienteViewModel> GetClientes()
        {
            return _clientesService.GetClientes();
        }

        [HttpPost]
        public string CadastraCliente([FromForm]ClienteViewModel cliente) 
        {
            return _clientesService.CadastraCliente(cliente);
        }

    }
}
