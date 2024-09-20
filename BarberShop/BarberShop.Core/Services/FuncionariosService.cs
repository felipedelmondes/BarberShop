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
    public class FuncionariosService : IFuncionariosServices
    {
        private readonly IFuncionariosRepositories _repository;

        public FuncionariosService(IFuncionariosRepositories repository)
        {
            _repository = repository;
        }

        public List<FuncionarioViewModel> GetFuncionarios()
        {
            return _repository.GetFuncionarios();
        }
    }
}
