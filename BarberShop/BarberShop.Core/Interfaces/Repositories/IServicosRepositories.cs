using BarberShop.Core.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop.Core.Interfaces.Repositories
{
    public interface IServicosRepositories
    {
        List<ServicosViewModel> GetServicos();
    }
}
