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
    public class SaidaConfiguration : IEntityTypeConfiguration<Saida>
    {
        public void Configure(EntityTypeBuilder<Saida> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Valor).IsRequired();
            builder.Property(x => x.Observacao).HasMaxLength(3000).IsRequired();
            builder.Property(x => x.DataVencimento).IsRequired();
            builder.Property(x => x.Ativo).IsRequired();
            builder.HasOne(x => x.TipoSaida)
                   .WithMany()
                   .HasForeignKey(x => x.IdTipoSaida);
            builder.HasOne(x => x.FormaPagamento)
                   .WithMany()
                   .HasForeignKey(x => x.IdTipoFormaPagamento);
            builder.HasOne(x => x.Parcela)
                   .WithMany()
                   .HasForeignKey(x => x.IdParcela);
        }
    }
}
