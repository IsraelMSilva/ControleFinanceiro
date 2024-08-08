using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Infrastructure.Repositories.Mock
{
    public class EntradaMock : IEntradaRepository
    {
        private readonly List<Entrada> _entrada;
        public EntradaMock()
        {
            _entrada = [];
        }

        public Task<Entrada> AtualizarAsync(Entrada entity)
        {
            var entrada = _entrada.First(a => a.Id == entity.Id);
            return Task.FromResult(entrada);
        }

        public Task<Entrada> CriarAsync(Entrada entity)
        {
            _entrada.Add(entity);
            var entrada = _entrada.First(a => a.Id == entity.Id);

            return Task.FromResult(entrada);
        }

        public Task DeletarAsync(Entrada entity)
        {
            _entrada.Remove(entity);
            return Task.FromResult(entity);
        }

        public Task<Entrada> ObterPorIdAsync(Guid id)
        {
            var entrada = _entrada.First(a => a.Id == id);
            return Task.FromResult(entrada);
        }

        public Task<IEnumerable<Entrada>> ObterTodosAsync()
        {
            // PODERIA OBTER A DESCRIÇÃO QUE TEM DENTRO DA TIPO ENTRADA PELA ENTRADA?
            throw new NotImplementedException();
        }
    }
}
