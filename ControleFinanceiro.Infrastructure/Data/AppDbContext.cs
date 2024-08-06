using ControleFinanceiro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Infrastructure.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Usuario> Usuarios { get; set; }
		public DbSet<Saida> Saidas { get; set; }
		public DbSet<TipoCategoria> TipoCategoria { get; set; }
		public DbSet<TipoSaida> TipoSaida { get; set; }
		public DbSet<TipoFormaPagamento> TipoFormaPagamento { get; set; }
		public DbSet<Parcela> Parcelas { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
