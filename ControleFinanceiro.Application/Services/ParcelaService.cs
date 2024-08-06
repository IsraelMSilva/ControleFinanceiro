using ControleFinanceiro.Application.DTOs;
using ControleFinanceiro.Application.Interfaces;
using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Domain.Repositories;
using ControleFinanceiro.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ControleFinanceiro.Application.DTOs.ParcelaDTO;
using static ControleFinanceiro.Application.DTOs.TipoSaidaDTO;

namespace ControleFinanceiro.Application.Services
{
	public class ParcelaService : IParcelaService
	{
		private readonly IParcelaRepository _parcelaRepository;
		public ParcelaService(IParcelaRepository parcelaRepository)
		{
			_parcelaRepository = parcelaRepository;
		}

		public async Task<Parcela> AdicionarParcela(AdicionarParcelaDTO adicionarParcelaDTO)
		{
			Parcela parcela = Parcela.CadastrarParcela(adicionarParcelaDTO.totalParcela, adicionarParcelaDTO.numeroParcela, adicionarParcelaDTO.valorPago, adicionarParcelaDTO.dataPagamento);
			return await _parcelaRepository.CriarAsync(parcela);
		}

		public async Task<Parcela> AtualizarParcela(AtualizarParcelaDTO alterarParcelaDTO)
		{
			Parcela retorno = await _parcelaRepository.ObterPorIdAsync(alterarParcelaDTO.Id);

			if (retorno == null)
				throw new Exception("Parcela não encontrada!");

			retorno.EditarParcela(alterarParcelaDTO.totalParcela, alterarParcelaDTO.numeroParcela, alterarParcelaDTO.valorPago, alterarParcelaDTO.dataPagamento);

			return await _parcelaRepository.AtualizarAsync(retorno);
		}
		
		public async Task<Parcela> AtualizarParcelaDataPagamento(AtualizarParcelaDataPagamentoDTO atualizarParcelaDataPagamentoDTO)
		{
			Parcela retorno = await _parcelaRepository.ObterPorIdAsync(atualizarParcelaDataPagamentoDTO.Id);

			if (retorno == null)
				throw new Exception("Parcela não encontrada!");

			retorno.EditarDataPagamento(atualizarParcelaDataPagamentoDTO.dataPagamento);

			return await _parcelaRepository.AtualizarAsync(retorno);
		}
		
		public async Task<Parcela> AtualizarParcelaNumeroParcela(AtualizarParcelaNumeroParcelaDTO atualizarParcelaNumeroParcelaDTO)
		{
			Parcela retorno = await _parcelaRepository.ObterPorIdAsync(atualizarParcelaNumeroParcelaDTO.Id);

			if (retorno == null)
				throw new Exception("Parcela não encontrada!");

			retorno.EditarNumeroParcela(atualizarParcelaNumeroParcelaDTO.numeroParcela);

			return await _parcelaRepository.AtualizarAsync(retorno);
		}
		
		public async Task<Parcela> AtualizarParcelaTotalParcela(AtualizarParcelaTotalParcelaDTO atualizarParcelaTotalParcelaDTO)
		{
			Parcela retorno = await _parcelaRepository.ObterPorIdAsync(atualizarParcelaTotalParcelaDTO.Id);

			if (retorno == null)
				throw new Exception("Parcela não encontrada!");

			retorno.EditarTotalParcela(atualizarParcelaTotalParcelaDTO.totalParcela);

			return await _parcelaRepository.AtualizarAsync(retorno);
		}
		
		public async Task<Parcela> AtualizarParcelaValorPago(AtualizarParcelaValorPagoDTO atualizarParcelaValorPagoDTO)
		{
			Parcela retorno = await _parcelaRepository.ObterPorIdAsync(atualizarParcelaValorPagoDTO.Id);

			if (retorno == null)
				throw new Exception("Parcela não encontrada!");

			retorno.EditarValorPago(atualizarParcelaValorPagoDTO.valorPago);

			return await _parcelaRepository.AtualizarAsync(retorno);
		}

		public async Task RemoverParcela(Guid id)
		{
			Parcela retorno = await _parcelaRepository.ObterPorIdAsync(id);
			retorno.InativarParcela();
			await _parcelaRepository.AtualizarAsync(retorno);
		}

		public async Task<Parcela> RetornaParcelaPorId(Guid id)
		{
			return await _parcelaRepository.ObterPorIdAsync(id);
		}

		public async Task<IEnumerable<Parcela>> RetornaTodasParcelas()
		{
			return await _parcelaRepository.ObterTodosAsync();
		}
	}
}
