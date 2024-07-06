using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Infrastructure.Repositories
{
    public class EntradaRepository : IEntradaRepository
    {
        public Task<Entrada> AtualizarAsync(Entrada entity)
        {
            throw new NotImplementedException();
        }

        public Task<Entrada> CriarAsync(Entrada entity)
        {
            throw new NotImplementedException();
        }

        public Task DeletarAsync(Entrada entity)
        {
            throw new NotImplementedException();
        }

        public Task<Entrada> ObterPorIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Entrada>> ObterTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
