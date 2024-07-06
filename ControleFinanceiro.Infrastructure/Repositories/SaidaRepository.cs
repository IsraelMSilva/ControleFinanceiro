using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Infrastructure.Repositories
{
    public class SaidaRepository : ISaidaRepository
    {
        public Task<Saida> AtualizarAsync(Saida entity)
        {
            throw new NotImplementedException();
        }

        public Task<Saida> CriarAsync(Saida entity)
        {
            throw new NotImplementedException();
        }

        public Task DeletarAsync(Saida entity)
        {
            throw new NotImplementedException();
        }

        public Task<Saida> ObterPorIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Saida>> ObterTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
