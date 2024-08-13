using ControleFinanceiro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Infrastructure.Data.Configuration
{
	public class LancamentoConfiguration : IEntityTypeConfiguration<Lancamento>
	{
		public void Configure(EntityTypeBuilder<Lancamento> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Data).IsRequired();
			builder.Property(x => x.Ativo).IsRequired();

			builder.HasOne(x => x.TipoLancamento)
				   .WithMany()
				   .HasForeignKey(x => x.IdTipoLancamento);

			builder.HasOne(x => x.Saida)
				   .WithMany()
				   .HasForeignKey(x => x.IdSaida);

			builder.HasOne(x => x.Entrada)
				   .WithMany()
				   .HasForeignKey(x => x.IdEntrada);
		}
	}
}
