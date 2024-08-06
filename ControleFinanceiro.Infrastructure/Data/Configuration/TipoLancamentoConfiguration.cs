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
    public class TipoLancamentoConfiguration : IEntityTypeConfiguration<TipoLancamento>
    {
        public void Configure(EntityTypeBuilder<TipoLancamento> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(150);
            builder.Property(x => x.IdTipoLancamento).IsRequired();
            builder.Property(x => x.Ativo).IsRequired();
        }
    }
}
