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
    public class FuncionariosRepositories : IFuncionariosRepositories
    {
        private readonly DBContext _dbContext;

        public FuncionariosRepositories(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<FuncionarioViewModel> GetFuncionarios()
        {
            try
            {
                var funcionarios = new List<FuncionarioViewModel>();
                var query = @" select 
	                            f.nome ,
	                            f.telefone ,
	                            f.especialidade ,
	                            f.data_contratacao 
                            from funcionarios f 
                            order by 1";

                using (var conn = _dbContext.CreateConnection())
                {
                    var result = conn.Query<FuncionarioViewModel>(query);

                    foreach(var lista in result)
                    {
                        funcionarios.Add(lista);
                    }
                }

                return funcionarios;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
