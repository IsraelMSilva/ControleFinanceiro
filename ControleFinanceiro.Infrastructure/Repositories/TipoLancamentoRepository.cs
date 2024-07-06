using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Infrastructure.Repositories
{
    public class TipoLancamentoRepository : ITipoLancamentoRepository
    {
        public Task<TipoLancamento> AtualizarAsync(TipoLancamento entity)
        {
            throw new NotImplementedException();
        }

        public Task<TipoLancamento> CriarAsync(TipoLancamento entity)
        {
            throw new NotImplementedException();
        }

        public Task DeletarAsync(TipoLancamento entity)
        {
            throw new NotImplementedException();
        }

        public Task<TipoLancamento> ObterPorIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TipoLancamento>> ObterTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
