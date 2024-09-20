using BarberShop.Core.Interfaces.Repositories;
using BarberShop.Core.Models.ViewModels;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShop.Repository.Repositories
{
    public class ClientesRepositories : IClientesRepositories
    {

        private readonly DBContext _dbContext;

        public ClientesRepositories(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string CadastraCliente(ClienteViewModel cliente)
        {
            var resultado = string.Empty;
            try
            {                
                var insert = $" INSERT INTO CLIENTES (NOME, TELEFONE, EMAIL) VALUES('{cliente.nome.ToUpper()}','{cliente.telefone}','{cliente.email.ToUpper()}') ";

                using(var conn = _dbContext.CreateConnection())
                {
                    conn.Query<string>(insert);
                    resultado = "Cadastro realizado com sucesso";
                }

                return resultado;
                
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public List<ClienteViewModel> GetClientes()
        {
            try
            {                

                var query = @"select
	                            c.nome ,
	                            c.telefone ,
	                            c.email 
                            from clientes c  ";

                using (var conn = _dbContext.CreateConnection())
                {
                    return conn.Query<ClienteViewModel>(query).ToList();                   
                }
             
            }
            catch (Exception ex) 
            {
                throw;
            }

        }
    }
}
