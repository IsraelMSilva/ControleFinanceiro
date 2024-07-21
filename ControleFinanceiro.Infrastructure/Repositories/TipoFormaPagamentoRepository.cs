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
    public class TipoFormaPagamentoRepository : ITipoFormaPagamentoRepository
    {
		private readonly AppDbContext _appDbContext;
		public TipoFormaPagamentoRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}

		public async Task<TipoFormaPagamento> AtualizarAsync(TipoFormaPagamento entity)
        {
			_appDbContext.TipoFormaPagamento.Update(entity);
			await _appDbContext.SaveChangesAsync();
			return entity;
		}

        public async Task<TipoFormaPagamento> CriarAsync(TipoFormaPagamento entity)
        {
			await _appDbContext.TipoFormaPagamento.AddAsync(entity);
			await _appDbContext.SaveChangesAsync();
			return entity;
		}

        public async Task DeletarAsync(TipoFormaPagamento entity)
        {
			_appDbContext.TipoFormaPagamento.Update(entity);
			await _appDbContext.SaveChangesAsync();
		}

        public async Task<TipoFormaPagamento> ObterPorIdAsync(Guid id)
        {
			return await _appDbContext.TipoFormaPagamento.FindAsync(id);
		}

        public async Task<IEnumerable<TipoFormaPagamento>> ObterTodosAsync()
        {
			return await _appDbContext.TipoFormaPagamento.Where(x => x.Ativo).ToListAsync();
		}

		public async Task<IEnumerable<TipoFormaPagamento>> ObterTipoFormaPagamentoPorDescricao(string descricao)
		{
			return await _appDbContext.TipoFormaPagamento.Where(a => a.Descricao.Contains(descricao) && a.Ativo).ToListAsync();
		}
	}
}
