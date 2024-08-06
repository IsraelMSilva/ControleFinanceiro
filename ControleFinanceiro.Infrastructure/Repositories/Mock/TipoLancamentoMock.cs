using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Infrastructure.Repositories.Mock
{
    public class TipoLancamentoMock : ITipoLancamentoRepository
    {
        private readonly List<TipoLancamento> _tipoLancamento;
        public TipoLancamentoMock()
        {
            _tipoLancamento = [];
        }

        public Task<TipoLancamento> AtualizarAsync(TipoLancamento entity)
        {
            var lancamento = _tipoLancamento.First(a => a.Id == entity.Id);
            return Task.FromResult(lancamento);
        }

        public Task<TipoLancamento> CriarAsync(TipoLancamento entity)
        {
            _tipoLancamento.Add(entity);
            var lancamento = _tipoLancamento.First(a => a.Id == entity.Id);

            return Task.FromResult(lancamento);
        }

        public Task DeletarAsync(TipoLancamento entity)
        {
            _tipoLancamento.Remove(entity);
            return Task.FromResult(entity);
        }

        public Task<TipoLancamento> ObterPorIdAsync(Guid id)
        {
            var lancamento = _tipoLancamento.First(a => a.Id == id);
            return Task.FromResult(lancamento);
        }

		public Task<IEnumerable<TipoLancamento>> ObterTipoLancamentoPorDescricao(string descricao)
		{
			return Task.FromResult(_tipoLancamento.Where(a => a.Descricao == descricao));
		}

		public Task<IEnumerable<TipoLancamento>> ObterTodosAsync()
        {
            return Task.FromResult(_tipoLancamento.Where(a => a.Descricao != null));
        }
    }
}
