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
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _appDbContext;
        public UsuarioRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<Usuario> AtualizarAsync(Usuario entity)
        {
            _appDbContext.Usuarios.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Usuario> CriarAsync(Usuario entity)
        {
            await _appDbContext.Usuarios.AddAsync(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeletarAsync(Usuario entity)
        {
            _appDbContext.Usuarios.Update(entity);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<Usuario> ObterPorIdAsync(Guid id)
        {
          return await _appDbContext.Usuarios.FindAsync(id);
        }

        public async Task<IEnumerable<Usuario>> ObterTodosAsync()
        {
            return await _appDbContext.Usuarios.ToListAsync();
        }
    }
}
