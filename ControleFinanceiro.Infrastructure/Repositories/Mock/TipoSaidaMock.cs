using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Infrastructure.Repositories.Mock
{
	public class TipoSaidaMock : ITipoSaidaRepository
	{
		private readonly List<TipoSaida> _tipoSaidas;
		public TipoSaidaMock()
		{
			_tipoSaidas = [];
		}

		public Task<TipoSaida> AtualizarAsync(TipoSaida entity)
		{
			var tipoSaida = _tipoSaidas.First(a => a.Id == entity.Id);
			return Task.FromResult(tipoSaida);
		}

		public Task<TipoSaida> CriarAsync(TipoSaida entity)
		{
			_tipoSaidas.Add(entity);
			var tipoSaida = _tipoSaidas.First(a => a.Id == entity.Id);

			return Task.FromResult(tipoSaida);
		}

		public Task DeletarAsync(TipoSaida entity)
		{
			_tipoSaidas.Remove(entity);
			return Task.FromResult(entity);
		}

		public Task<TipoSaida> ObterPorIdAsync(Guid id)
		{
			var tipoSaida = _tipoSaidas.First(a => a.Id == id);
			return Task.FromResult(tipoSaida);
		}

		public Task<IEnumerable<TipoSaida>> ObterTipoSaidaPorDescricao(string descricao)
		{
			return Task.FromResult(_tipoSaidas.Where(a => a.Descricao == descricao));
		}

		public Task<IEnumerable<TipoSaida>> ObterTodosAsync()
		{
			return Task.FromResult(_tipoSaidas.Where(a => a.Ativo));
		}
	}
}
