using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Application.DTOs
{
	public class SaidaDTO
	{
		public record AdicionarSaidaDTO(decimal valor, Guid idTipoSaida, Guid idTipoFormaPagamento, DateTime dataVencimento, string observacao, Guid idParcela);
		public record AtualizarSaidaDTO(Guid Id, decimal valor, Guid idTipoSaida, Guid idTipoFormaPagamento, DateTime dataVencimento, string observacao, Guid idParcela);
		public record AtualizarSaidaValorDTO(Guid Id, decimal valor);
		public record AtualizarSaidaTipoSaidaDTO(Guid Id, Guid idTipoSaida);
		public record AtualizarSaidaTipoFormaPagamentoDTO(Guid Id, Guid idTipoFormaPagamento);
		public record AtualizarSaidaDataVencimentoDTO(Guid Id, DateTime dataVencimento);
		public record AtualizarSaidaObservacaoDTO(Guid Id, string observacao);
		public record AtualizarSaidaParcelaDTO(Guid Id, Guid idParcela);
	}
}

