using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Infrastructure.Repositories.Mock
{
    public class TipoEntradaMock : ITipoEntradaRepository
    {
        private readonly List<TipoEntrada> _tipoEntrada;
        public TipoEntradaMock()
        {
            _tipoEntrada = [];
        }

        public Task<TipoEntrada> AtualizarAsync(TipoEntrada entity)
        {
            var entrada = _tipoEntrada.First(a => a.Id == entity.Id);
            return Task.FromResult(entrada);
        }

        public Task<TipoEntrada> CriarAsync(TipoEntrada entity)
        {
            _tipoEntrada.Add(entity);
            var entrada = _tipoEntrada.First(a => a.Id == entity.Id);

            return Task.FromResult(entrada);
        }

        public Task DeletarAsync(TipoEntrada entity)
        {
            _tipoEntrada.Remove(entity);
            return Task.FromResult(entity);
        }

        public Task<TipoEntrada> ObterPorIdAsync(Guid id)
        {
            var entrada = _tipoEntrada.First(a => a.Id == id);
            return Task.FromResult(entrada);
        }

        public Task<IEnumerable<TipoEntrada>> ObterTipoEntradaPorDescricao(string descricao)
        {
            return Task.FromResult(_tipoEntrada.Where(a => a.Descricao == descricao));
        }

        public Task<IEnumerable<TipoEntrada>> ObterTodosAsync()
        {
            return Task.FromResult(_tipoEntrada.Where(a => a.Descricao != null));
        }
    }
}
