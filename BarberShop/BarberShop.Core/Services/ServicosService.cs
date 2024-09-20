using BarberShop.Core.Interfaces.Repositories;
using BarberShop.Core.Interfaces.Services;
using BarberShop.Core.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop.Core.Services
{
    public class ServicosService : IServicosService
    {
        private readonly IServicosRepositories _services;

        public ServicosService(IServicosRepositories services)
        {
            _services = services;
        }

        public List<ServicosViewModel> GetServicos()
        {
            return _services.GetServicos();
        }
    }
}
