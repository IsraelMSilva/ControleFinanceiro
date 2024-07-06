using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Infrastructure.Repositories
{
    public class TipoSaidaRepository : ITipoSaidaRepository
    {
        public Task<TipoSaida> AtualizarAsync(TipoSaida entity)
        {
            throw new NotImplementedException();
        }

        public Task<TipoSaida> CriarAsync(TipoSaida entity)
        {
            throw new NotImplementedException();
        }

        public Task DeletarAsync(TipoSaida entity)
        {
            throw new NotImplementedException();
        }

        public Task<TipoSaida> ObterPorIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TipoSaida>> ObterTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
