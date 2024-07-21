using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Application.DTOs
{
	public class TipoFormaPagamentoDTO
	{
		public record AdicionarTipoFormaPagamentoDTO(string Descricao);
		public record AlterarTipoFormaPagamentoDTO(Guid Id, string Descricao);
	}
}
