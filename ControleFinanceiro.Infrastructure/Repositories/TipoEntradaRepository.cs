using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Infrastructure.Repositories
{
    public class TipoEntradaRepository : ITipoEntradaRepository
    {
        public Task<TipoEntrada> AtualizarAsync(TipoEntrada entity)
        {
            throw new NotImplementedException();
        }

        public Task<TipoEntrada> CriarAsync(TipoEntrada entity)
        {
            throw new NotImplementedException();
        }

        public Task DeletarAsync(TipoEntrada entity)
        {
            throw new NotImplementedException();
        }

        public Task<TipoEntrada> ObterPorIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TipoEntrada>> ObterTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
