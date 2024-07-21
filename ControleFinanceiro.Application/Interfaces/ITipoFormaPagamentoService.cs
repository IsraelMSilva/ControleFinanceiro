
using ControleFinanceiro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ControleFinanceiro.Application.DTOs.TipoFormaPagamentoDTO;

namespace ControleFinanceiro.Application.Interfaces
{
	public interface ITipoFormaPagamentoService
	{
		Task<TipoFormaPagamento> AdicionarTipoFormaPagamento(AdicionarTipoFormaPagamentoDTO adicionarTipoFormaPagamentoDTO);
		Task<TipoFormaPagamento> AtualizarTipoFormaPagamento(AlterarTipoFormaPagamentoDTO alterarTipoFormaPagamentoDTO);
		Task<TipoFormaPagamento> RetornaTipoFormaPagamentoPorId(Guid id);
		Task<IEnumerable<TipoFormaPagamento>> RetornaTodosTipoFormaPagamento();
		Task<IEnumerable<TipoFormaPagamento>> RetornaTipoFormaPagamentoPorDescricao(string descricao);
		Task RemoverTipoFormaPagamento(Guid id);
	}
}
