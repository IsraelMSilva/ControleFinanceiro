using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Infrastructure.Repositories
{
    public class LancamentoRepository : ILancamentoRepository
    {
        public Task<Lancamento> AtualizarAsync(Lancamento entity)
        {
            throw new NotImplementedException();
        }

        public Task<Lancamento> CriarAsync(Lancamento entity)
        {
            throw new NotImplementedException();
        }

        public Task DeletarAsync(Lancamento entity)
        {
            throw new NotImplementedException();
        }

        public Task<Lancamento> ObterPorIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Lancamento>> ObterTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
