using BarberShop.Core.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop.Core.Interfaces.Services
{
    public interface IAgendamentoService
    {
        Task<AgendamentoResponse> Agendamento(AgendamentoRequest agendamento);
    }
}
