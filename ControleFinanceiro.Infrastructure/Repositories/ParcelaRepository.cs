using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Infrastructure.Repositories
{
    public class ParcelaRepository : IParcelaRepository
    {
        public Task<Parcela> AtualizarAsync(Parcela entity)
        {
            throw new NotImplementedException();
        }

        public Task<Parcela> CriarAsync(Parcela entity)
        {
            throw new NotImplementedException();
        }

        public Task DeletarAsync(Parcela entity)
        {
            throw new NotImplementedException();
        }

        public Task<Parcela> ObterPorIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Parcela>> ObterTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
