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
    public class TipoEntradaRepository : ITipoEntradaRepository
    {
        private readonly AppDbContext _appDbContext;
        public TipoEntradaRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<TipoEntrada> AtualizarAsync(TipoEntrada entity)
        {
            _appDbContext.TipoEntrada.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TipoEntrada> CriarAsync(TipoEntrada entity)
        {
            await _appDbContext.TipoEntrada.AddAsync(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeletarAsync(TipoEntrada entity)
        {
            _appDbContext.TipoEntrada.Update(entity);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<TipoEntrada> ObterPorIdAsync(Guid id)
        {
            return await _appDbContext.TipoEntrada.FindAsync(id);
        }

        public async Task<IEnumerable<TipoEntrada>> ObterTipoEntradaPorDescricao(string descricao)
        {
            return await _appDbContext.TipoEntrada.Where(a => a.Descricao.Contains(descricao) && a.Ativo).ToListAsync();
        }

        public async Task<IEnumerable<TipoEntrada>> ObterTodosAsync()
        {
            return await _appDbContext.TipoEntrada.Where(x => x.Ativo).ToListAsync();
        }
    }
}
