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
    public class TipoCategoriaRepository : ITipoCategoriaRepository
    {
        private readonly AppDbContext _appDbContext;
        public UsuarioRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public Task<TipoCategoria> AtualizarAsync(TipoCategoria entity)
        {
            _appDbContext.TipoCategoria.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public Task<TipoCategoria> CriarAsync(TipoCategoria entity)
        {
            await _appDbContext.TipoCategoria.AddAsync(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public Task DeletarAsync(TipoCategoria entity)
        {
            _appDbContext.TipoCategoria.Update(entity);
            await _appDbContext.SaveChangesAsync();
        }

        public Task<TipoCategoria> ObterPorIdAsync(Guid id)
        {
            return await _appDbContext.TipoCategoria.FindAsync(id);
        }

        public Task<IEnumerable<TipoCategoria>> ObterTodosAsync()
        {
            return await _appDbContext.TipoCategoria.Where(x => x.Ativo).ToListAsync();
        }

        public async Task<IEnumerable<TipoCategoria>> ObterTipoCategoriaPorDescricao(string descricao)
        {
            return await _appDbContext.TipoCategoria.Where(a => a.Descricao.Contains(descricao) && a.Ativo).ToListAsync();
        }
    }
}
