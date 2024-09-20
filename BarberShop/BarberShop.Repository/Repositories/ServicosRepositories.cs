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
    public class ServicosRepositories : IServicosRepositories
    {
        private readonly DBContext _dbContext;

        public ServicosRepositories(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<ServicosViewModel> GetServicos()
        {           

            try
            {
                var query = @" select s.descricao ,s.preco from servicos s ";

                using (var conn = _dbContext.CreateConnection())
                {
                   return conn.Query<ServicosViewModel>(query).ToList();                   
                }
         
            }
            catch (Exception ex) { throw; }
        }
    }
}
