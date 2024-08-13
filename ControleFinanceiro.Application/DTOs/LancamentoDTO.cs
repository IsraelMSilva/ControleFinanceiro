using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Application.DTOs
{
	public class LancamentoDTO
	{
		public record AdicionarLancamentoDTO(DateTime dataLancamento, Guid idTipoLancamento, Guid idSaida, Guid idEntrada);
		public record AtualizarLancamentoDTO(Guid Id, DateTime dataLancamento, Guid idTipoLancamento, Guid idSaida, Guid idEntrada);
		public record AtualizarLancamentoDataDTO(Guid Id, DateTime dataLancamento);
		public record AtualizarLancamentoTipoLancamentoDTO(Guid Id, Guid idTipoLancamento, Guid idSaida, Guid idEntrada);
	}
}
