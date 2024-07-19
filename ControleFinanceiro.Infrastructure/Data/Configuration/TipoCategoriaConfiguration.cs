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
    public class TipoCategoriaConfiguration : IEntityTypeConfiguration<TipoCategoria>
    {
        public void Configure(EntityTypeBuilder<TipoCategoria> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(150);
            builder.Property(x => x.IdTipoSaida).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Ativo).IsRequired();
        }
    }
}
