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
	public class ParcelaRepository : IParcelaRepository
	{
		private readonly AppDbContext _appDbContext;
		public ParcelaRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}

		public async Task<Parcela> AtualizarAsync(Parcela entity)
		{
			_appDbContext.Parcelas.Update(entity);
			await _appDbContext.SaveChangesAsync();
			return entity;
		}

		public async Task<Parcela> CriarAsync(Parcela entity)
		{
			await _appDbContext.Parcelas.AddAsync(entity);
			await _appDbContext.SaveChangesAsync();
			return entity;
		}

		public async Task DeletarAsync(Parcela entity)
		{
			_appDbContext.Parcelas.Update(entity);
			await _appDbContext.SaveChangesAsync();
		}

		public async Task<Parcela> ObterPorIdAsync(Guid id)
		{
			return await _appDbContext.Parcelas.FindAsync(id);
		}

		public async Task<IEnumerable<Parcela>> ObterTodosAsync()
		{
			return await _appDbContext.Parcelas.Where(x => x.Ativo).ToListAsync();
		}
	}
}
