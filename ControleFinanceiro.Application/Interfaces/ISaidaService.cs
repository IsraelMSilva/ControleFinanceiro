using ControleFinanceiro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ControleFinanceiro.Application.DTOs.SaidaDTO;

namespace ControleFinanceiro.Application.Interfaces
{
	public interface ISaidaService
	{
		Task<Saida> AdicionarSaida(AdicionarSaidaDTO adicionarSaidaDTO);
		Task<Saida> AtualizarSaida(AtualizarSaidaDTO atualizarSaidaDTO);
		Task<Saida> AtualizarSaidaValor(AtualizarSaidaValorDTO atualizarSaidaValorDTO);
		Task<Saida> AtualizarSaidaTipoSaida(AtualizarSaidaTipoSaidaDTO atualizarSaidaTipoSaidaDTO);
		Task<Saida> AtualizarSaidaTipoFormaPagamento(AtualizarSaidaTipoFormaPagamentoDTO atualizarSaidaTipoFormaPagamentoDTO);
		Task<Saida> AtualizarSaidaDataVencimento(AtualizarSaidaDataVencimentoDTO atualizarSaidaDataVencimentoDTO);
		Task<Saida> AtualizarSaidaObservacao(AtualizarSaidaObservacaoDTO atualizarSaidaObservacaoDTO);
		Task<Saida> AtualizarSaidaParcela(AtualizarSaidaParcelaDTO atualizarSaidaParcelaDTO);
		Task<Saida> RetornaSaidaPorId(Guid id);
		Task<IEnumerable<Saida>> RetornaTodosSaida();
		Task RemoverSaida(Guid id);
	}
}
