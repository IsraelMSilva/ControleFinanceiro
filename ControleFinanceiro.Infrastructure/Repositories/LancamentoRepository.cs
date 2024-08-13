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
    public class LancamentoRepository : ILancamentoRepository
    {
		private readonly AppDbContext _appDbContext;
		public LancamentoRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}

		public async Task<Lancamento> AtualizarAsync(Lancamento entity)
        {
			_appDbContext.Lancamentos.Update(entity);
			await _appDbContext.SaveChangesAsync();
			return entity;
		}

        public async Task<Lancamento> CriarAsync(Lancamento entity)
        {
			await _appDbContext.Lancamentos.AddAsync(entity);
			await _appDbContext.SaveChangesAsync();
			return entity;
		}

        public async Task DeletarAsync(Lancamento entity)
        {
			_appDbContext.Lancamentos.Update(entity);
			await _appDbContext.SaveChangesAsync();
		}

        public async Task<Lancamento> ObterPorIdAsync(Guid id)
        {
			return await _appDbContext.Lancamentos.FindAsync(id);
		}

        public async Task<IEnumerable<Lancamento>> ObterTodosAsync()
        {
			return await _appDbContext.Lancamentos.Where(x => x.Ativo).ToListAsync();
		}
    }
}
