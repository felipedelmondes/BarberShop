using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop.Core.Models.ViewModels
{
    public class FuncionarioViewModel
    {
        public string nome { get; set; }
        public string telefone { get; set; }
        public string especialidade { get; set; }
        public DateTime dataContratacao { get; set; }
    }
}
