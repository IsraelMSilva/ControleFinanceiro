using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Domain.Repositories;
using ControleFinanceiro.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Infrastructure.Repositories
{
    public class TipoSaidaRepository : ITipoSaidaRepository
    {
		private readonly AppDbContext _appDbContext;
		public TipoSaidaRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}

		public async Task<TipoSaida> AtualizarAsync(TipoSaida entity)
        {
			_appDbContext.TipoSaida.Update(entity);
			await _appDbContext.SaveChangesAsync();
			return entity;
		}

        public async Task<TipoSaida> CriarAsync(TipoSaida entity)
        {
			await _appDbContext.TipoSaida.AddAsync(entity);
			await _appDbContext.SaveChangesAsync();
			return entity;
		}

        public async Task DeletarAsync(TipoSaida entity)
        {
			_appDbContext.TipoSaida.Update(entity);
			await _appDbContext.SaveChangesAsync();
		}

        public async Task<TipoSaida> ObterPorIdAsync(Guid id)
        {
			return await _appDbContext.TipoSaida.FindAsync(id);
		}

        public async Task<IEnumerable<TipoSaida>> ObterTodosAsync()
        {
			return await _appDbContext.TipoSaida.Where(x => x.Ativo).ToListAsync();
		}

		public async Task<IEnumerable<TipoSaida>> ObterTipoSaidaPorDescricao(string descricao)
		{
			return await _appDbContext.TipoSaida.Where(a => a.Descricao.Contains(descricao) && a.Ativo).ToListAsync();
		}
	}
}
