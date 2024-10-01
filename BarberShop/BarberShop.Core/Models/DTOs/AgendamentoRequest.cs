using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop.Core.Models.DTOs
{
    public class AgendamentoRequest
    {
        public int client_id { get; set; }
        public int funcionario_id { get; set; }
        public int servico_id { get; set; }
        public DateTime data_agendamento { get; set; }
        public string hora_agendamento { get; set; } 
        public string status { get; set; }
    }
}
