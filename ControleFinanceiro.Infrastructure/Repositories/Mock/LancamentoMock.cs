using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Infrastructure.Repositories.Mock
{
	public class LancamentoMock : ILancamentoRepository
	{
		private readonly List<Lancamento> _lancamentos;
		public LancamentoMock()
		{
			_lancamentos = [];
		}

		public Task<Lancamento> AtualizarAsync(Lancamento entity)
		{
			var lancamento = _lancamentos.First(a => a.Id == entity.Id);
			return Task.FromResult(lancamento);
		}

		public Task<Lancamento> CriarAsync(Lancamento entity)
		{
			_lancamentos.Add(entity);
			var lancamento = _lancamentos.First(a => a.Id == entity.Id);

			return Task.FromResult(lancamento);
		}

		public Task DeletarAsync(Lancamento entity)
		{
			_lancamentos.Remove(entity);
			return Task.FromResult(entity);
		}

		public Task<Lancamento> ObterPorIdAsync(Guid id)
		{
			var lancamento = _lancamentos.First(a => a.Id == id);
			return Task.FromResult(lancamento);
		}

		public Task<IEnumerable<Lancamento>> ObterTodosAsync()
		{
			return Task.FromResult(_lancamentos.Where(a => a.Ativo));
		}
	}
}
