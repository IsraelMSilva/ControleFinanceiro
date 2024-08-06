using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Application.DTOs
{
	public class ParcelaDTO
	{
		public record AdicionarParcelaDTO(int totalParcela, int numeroParcela, decimal valorPago, DateTime dataPagamento);
		public record AtualizarParcelaDTO(Guid Id, int totalParcela, int numeroParcela, decimal valorPago, DateTime dataPagamento);
		public record AtualizarParcelaTotalParcelaDTO(Guid Id, int totalParcela);
		public record AtualizarParcelaNumeroParcelaDTO(Guid Id, int numeroParcela);
		public record AtualizarParcelaValorPagoDTO(Guid Id, decimal valorPago);
		public record AtualizarParcelaDataPagamentoDTO(Guid Id, DateTime dataPagamento);
	}
}
