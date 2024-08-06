using ControleFinanceiro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ControleFinanceiro.Application.DTOs.ParcelaDTO;

namespace ControleFinanceiro.Application.Interfaces
{
	public interface IParcelaService
	{
		Task<Parcela> AdicionarParcela(AdicionarParcelaDTO adicionarTipoSaidaDTO);
		Task<Parcela> AtualizarParcela(AtualizarParcelaDTO alterarTipoSaidaDTO);
		Task<Parcela> AtualizarParcelaTotalParcela(AtualizarParcelaTotalParcelaDTO atualizarParcelaTotalParcelaDTO);
		Task<Parcela> AtualizarParcelaNumeroParcela(AtualizarParcelaNumeroParcelaDTO atualizarParcelaNumeroParcelaDTO);
		Task<Parcela> AtualizarParcelaValorPago(AtualizarParcelaValorPagoDTO atualizarParcelaValorPagoDTO);
		Task<Parcela> AtualizarParcelaDataPagamento(AtualizarParcelaDataPagamentoDTO atualizarParcelaDataPagamentoDTO);
		Task<Parcela> RetornaParcelaPorId(Guid id);
		Task<IEnumerable<Parcela>> RetornaTodasParcelas();
		Task RemoverParcela(Guid id);
	}
}
