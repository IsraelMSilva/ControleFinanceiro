using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Application.DTOs
{
	public class TipoSaidaDTO
	{
		public record AdicionarTipoSaidaDTO(string Descricao);
		public record AlterarTipoSaidaDTO(Guid Id, string Descricao);
	}
}
