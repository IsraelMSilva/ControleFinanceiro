using ControleFinanceiro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ControleFinanceiro.Application.DTOs.LancamentoDTO;

namespace ControleFinanceiro.Application.Interfaces
{
	public interface ILancamentoService
	{
		Task<Lancamento> AdicionarLancamento(AdicionarLancamentoDTO adicionarLancamentoDTO);
		Task<Lancamento> AtualizarLancamento(AtualizarLancamentoDTO atualizarLancamentoDTO);
		Task<Lancamento> AtualizarLancamentoData(AtualizarLancamentoDataDTO atualizarLancamentoDataDTO);
		Task<Lancamento> AtualizarLancamentoTipoLancamento(AtualizarLancamentoTipoLancamentoDTO atualizarLancamentoTipoLancamentoDTO);
		Task<Lancamento> RetornaLancamentoPorId(Guid id);
		Task<IEnumerable<Lancamento>> RetornaTodosLancamento();
		Task RemoverLancamento(Guid id);
	}
}
