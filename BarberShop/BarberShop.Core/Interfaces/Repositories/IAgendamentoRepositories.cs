using BarberShop.Core.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop.Core.Interfaces.Repositories
{
    public interface IAgendamentoRepositories
    {
        Task<AgendamentoResponse> Agendamento(AgendamentoRequest agendamento);
    }
}
