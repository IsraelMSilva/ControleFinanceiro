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
	public class ParcelaConfiguration : IEntityTypeConfiguration<Parcela>
	{
		public void Configure(EntityTypeBuilder<Parcela> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Ativo).IsRequired();
		}
	}
}
