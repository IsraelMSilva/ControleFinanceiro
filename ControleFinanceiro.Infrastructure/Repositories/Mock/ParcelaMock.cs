using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Infrastructure.Repositories.Mock
{
	public class ParcelaMock : IParcelaRepository
	{
		private readonly List<Parcela> _parcelas;
		public ParcelaMock()
		{
			_parcelas = [];
		}

		public Task<Parcela> AtualizarAsync(Parcela entity)
		{
			var parcela = _parcelas.First(a => a.Id == entity.Id);
			return Task.FromResult(parcela);
		}

		public Task<Parcela> CriarAsync(Parcela entity)
		{
			_parcelas.Add(entity);
			var parcela = _parcelas.First(a => a.Id == entity.Id);

			return Task.FromResult(parcela);
		}

		public Task DeletarAsync(Parcela entity)
		{
			_parcelas.Remove(entity);
			return Task.FromResult(entity);
		}

		public Task<Parcela> ObterPorIdAsync(Guid id)
		{
			var parcela = _parcelas.First(a => a.Id == id);
			return Task.FromResult(parcela);
		}

		public Task<IEnumerable<Parcela>> ObterTodosAsync()
		{
			return Task.FromResult(_parcelas.Where(a => a.Ativo));
		}
	}
}
