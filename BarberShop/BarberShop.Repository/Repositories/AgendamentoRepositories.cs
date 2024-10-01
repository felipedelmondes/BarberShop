using BarberShop.Core.Interfaces.Repositories;
using BarberShop.Core.Models.DTOs;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop.Repository.Repositories
{
    public class AgendamentoRepositories : IAgendamentoRepositories
    {
        private readonly DBContext _dbContext;

        public AgendamentoRepositories(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<AgendamentoResponse> Agendamento(AgendamentoRequest agendamento)
        {            

            var query = @$" insert into agendamentos (cliente_id, funcionario_id, servico_id, data_agendamento, hora_agendamento, status)
                            values ({agendamento.client_id}, {agendamento.funcionario_id}, {agendamento.servico_id},to_date('{agendamento.data_agendamento.ToShortDateString()}','DD/MM/YYYY'), '{agendamento.hora_agendamento}','{agendamento.status}')";

            var retorno = new AgendamentoResponse();

            try
            {
                using (var conn = _dbContext.CreateConnection())
                {
                    await conn.QueryAsync<string>(query);
                    retorno.DataAgendamentoResponse = agendamento.data_agendamento;
                    retorno.MensagemRetorno = @$"Agendamento realizado com sucesso, seu serviço esta agendamento para o dia {retorno.DataAgendamentoResponse.ToShortDateString()}";
                }

                return retorno;
            }
            catch (Exception ex) 
            {
                return new AgendamentoResponse();
            }
        }
    }
}
