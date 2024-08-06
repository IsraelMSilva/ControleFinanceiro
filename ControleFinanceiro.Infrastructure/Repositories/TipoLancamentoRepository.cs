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
    public class TipoLancamentoRepository : ITipoLancamentoRepository
    {
        private readonly AppDbContext _appDbContext;
        public TipoLancamentoRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<TipoLancamento> AtualizarAsync(TipoLancamento entity)
        {
            _appDbContext.TipoLancamento.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TipoLancamento> CriarAsync(TipoLancamento entity)
        {
            await _appDbContext.TipoLancamento.AddAsync(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeletarAsync(TipoLancamento entity)
        {
            _appDbContext.TipoLancamento.Update(entity);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<TipoLancamento> ObterPorIdAsync(Guid id)
        {
            return await _appDbContext.TipoLancamento.FindAsync(id);
        }

        public async Task<IEnumerable<TipoLancamento>> ObterTipoLancamentoPorDescricao(string descricao)
        {
            return await _appDbContext.TipoLancamento.Where(a => a.Descricao.Contains(descricao) && a.Ativo).ToListAsync();
        }

        public async Task<IEnumerable<TipoLancamento>> ObterTodosAsync()
        {
            return await _appDbContext.TipoLancamento.Where(x => x.Ativo).ToListAsync();
        }
    }
}
