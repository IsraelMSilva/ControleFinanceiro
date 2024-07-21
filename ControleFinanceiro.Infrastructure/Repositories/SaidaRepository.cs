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
    public class SaidaRepository : ISaidaRepository
    {
		private readonly AppDbContext _appDbContext;
		public SaidaRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}

		public async Task<Saida> AtualizarAsync(Saida entity)
        {
			_appDbContext.Saidas.Update(entity);
			await _appDbContext.SaveChangesAsync();
			return entity;
		}

        public async Task<Saida> CriarAsync(Saida entity)
        {
			await _appDbContext.Saidas.AddAsync(entity);
			await _appDbContext.SaveChangesAsync();
			return entity;
		}

        public async Task DeletarAsync(Saida entity)
        {
			_appDbContext.Saidas.Update(entity);
			await _appDbContext.SaveChangesAsync();
		}

        public async Task<Saida> ObterPorIdAsync(Guid id)
        {
			return await _appDbContext.Saidas.FindAsync(id);
		}

        public async Task<IEnumerable<Saida>> ObterTodosAsync()
        {
			return await _appDbContext.Saidas.Where(x => x.Ativo).ToListAsync();
		}
    }
}
