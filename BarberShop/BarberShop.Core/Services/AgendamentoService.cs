using BarberShop.Core.Interfaces.Repositories;
using BarberShop.Core.Interfaces.Services;
using BarberShop.Core.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop.Core.Services
{
    public class AgendamentoService : IAgendamentoService
    {
        private readonly IAgendamentoRepositories _repository;

        public AgendamentoService(IAgendamentoRepositories repository)
        {
            _repository = repository;
        }

        public Task<AgendamentoResponse> Agendamento(AgendamentoRequest agendamento)
        {
            TimeSpan horario = new TimeSpan();
            horario = TimeSpan.Parse(agendamento.hora_agendamento);
            agendamento.hora_agendamento = horario.ToString();
            return _repository.Agendamento(agendamento);
        }
    }
}
