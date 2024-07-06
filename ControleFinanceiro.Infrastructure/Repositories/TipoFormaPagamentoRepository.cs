using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Infrastructure.Repositories
{
    public class TipoFormaPagamentoRepository : ITipoFormaPagamentoRepository
    {
        public Task<TipoFormaPagamento> AtualizarAsync(TipoFormaPagamento entity)
        {
            throw new NotImplementedException();
        }

        public Task<TipoFormaPagamento> CriarAsync(TipoFormaPagamento entity)
        {
            throw new NotImplementedException();
        }

        public Task DeletarAsync(TipoFormaPagamento entity)
        {
            throw new NotImplementedException();
        }

        public Task<TipoFormaPagamento> ObterPorIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TipoFormaPagamento>> ObterTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
