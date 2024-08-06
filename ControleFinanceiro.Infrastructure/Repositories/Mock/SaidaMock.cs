using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Infrastructure.Repositories.Mock
{
	public class SaidaMock : ISaidaRepository
	{
		private readonly List<Saida> _saidas;
		public SaidaMock()
		{
			_saidas = [];
		}

		public Task<Saida> AtualizarAsync(Saida entity)
		{
			var saida = _saidas.First(a => a.Id == entity.Id);
			return Task.FromResult(saida);
		}

		public Task<Saida> CriarAsync(Saida entity)
		{
			_saidas.Add(entity);
			var saida = _saidas.First(a => a.Id == entity.Id);

			return Task.FromResult(saida);
		}

		public Task DeletarAsync(Saida entity)
		{
			_saidas.Remove(entity);
			return Task.FromResult(entity);
		}

		public Task<Saida> ObterPorIdAsync(Guid id)
		{
			var saida = _saidas.First(a => a.Id == id);
			return Task.FromResult(saida);
		}

		public Task<IEnumerable<Saida>> ObterTodosAsync()
		{
			return Task.FromResult(_saidas.Where(a => a.Ativo));
		}
	}
}
