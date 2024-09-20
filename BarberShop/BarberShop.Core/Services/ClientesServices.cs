using BarberShop.Core.Interfaces.Repositories;
using BarberShop.Core.Interfaces.Services;
using BarberShop.Core.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop.Core.Services
{
    public class ClientesServices : IClientesServices
    {
        private readonly IClientesRepositories _clienteRepositories;

        public ClientesServices(IClientesRepositories clienteRepositories)
        {
            _clienteRepositories = clienteRepositories;
        }

        public string CadastraCliente(ClienteViewModel cliente)
        {
            return _clienteRepositories.CadastraCliente(cliente);
        }

        public List<ClienteViewModel> GetClientes()
        {
            return _clienteRepositories.GetClientes();
        }
    }
}
