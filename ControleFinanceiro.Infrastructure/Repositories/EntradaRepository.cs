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
    public class EntradaRepository : IEntradaRepository
    {
        private readonly AppDbContext _appDbContext;
        public EntradaRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Entrada> AtualizarAsync(Entrada entity)
        {
            _appDbContext.Entrada.Update(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Entrada> CriarAsync(Entrada entity)
        {
            await _appDbContext.Entrada.AddAsync(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeletarAsync(Entrada entity)
        {
            _appDbContext.Entrada.Update(entity);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<Entrada> ObterPorIdAsync(Guid id)
        {
            return await _appDbContext.Entrada.FindAsync(id);
        }

        public Task<IEnumerable<Entrada>> ObterTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
