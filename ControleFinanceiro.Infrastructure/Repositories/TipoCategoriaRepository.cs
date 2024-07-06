using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Infrastructure.Repositories
{
    public class TipoCategoriaRepository : ITipoCategoriaRepository
    {
        public Task<TipoCategoria> AtualizarAsync(TipoCategoria entity)
        {
            throw new NotImplementedException();
        }

        public Task<TipoCategoria> CriarAsync(TipoCategoria entity)
        {
            throw new NotImplementedException();
        }

        public Task DeletarAsync(TipoCategoria entity)
        {
            throw new NotImplementedException();
        }

        public Task<TipoCategoria> ObterPorIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TipoCategoria>> ObterTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
