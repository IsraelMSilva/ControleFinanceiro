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
using static ControleFinanceiro.Application.DTOs.TipoFormaPagamentoDTO;
using static ControleFinanceiro.Application.DTOs.TipoSaidaDTO;

namespace ControleFinanceiro.Application.Services
{
	public class TipoFormaPagamentoService : ITipoFormaPagamentoService
	{
		private readonly ITipoFormaPagamentoRepository _tipoFormaPagamentoRepository;
		public TipoFormaPagamentoService(ITipoFormaPagamentoRepository tipoFormaPagamentoRepository)
		{
			_tipoFormaPagamentoRepository = tipoFormaPagamentoRepository;
		}

		public async Task<TipoFormaPagamento> AdicionarTipoFormaPagamento(AdicionarTipoFormaPagamentoDTO adicionarTipoFormaPagamentoDTO)
		{
			TipoFormaPagamento tipoFormaPagamento = TipoFormaPagamento.AdicionarFormaPagamento(adicionarTipoFormaPagamentoDTO.Descricao);
			return await _tipoFormaPagamentoRepository.CriarAsync(tipoFormaPagamento);
		}

		public async Task<TipoFormaPagamento> AtualizarTipoFormaPagamento(AlterarTipoFormaPagamentoDTO alterarTipoFormaPagamentoDTO)
		{
			TipoFormaPagamento retorno = await _tipoFormaPagamentoRepository.ObterPorIdAsync(alterarTipoFormaPagamentoDTO.Id);

			if (retorno == null)
				throw new Exception("Tipo de Forma de Pagamento não encontrada!");

			retorno.AtualizarFormaPagamento(alterarTipoFormaPagamentoDTO.Descricao);

			return await _tipoFormaPagamentoRepository.AtualizarAsync(retorno);
		}

		public async Task RemoverTipoFormaPagamento(Guid id)
		{
			TipoFormaPagamento retorno = await _tipoFormaPagamentoRepository.ObterPorIdAsync(id);
			retorno.InativarTipoFormaPagamento();
			await _tipoFormaPagamentoRepository.AtualizarAsync(retorno);
		}

		public async Task<IEnumerable<TipoFormaPagamento>> RetornaTipoFormaPagamentoPorDescricao(string descricao)
		{
			if (string.IsNullOrEmpty(descricao))
				throw new Exception("Insira a descrição para buscar!");

			return await _tipoFormaPagamentoRepository.ObterTipoFormaPagamentoPorDescricao(descricao);
		}

		public async Task<TipoFormaPagamento> RetornaTipoFormaPagamentoPorId(Guid id)
		{
			return await _tipoFormaPagamentoRepository.ObterPorIdAsync(id);
		}

		public async Task<IEnumerable<TipoFormaPagamento>> RetornaTodosTipoFormaPagamento()
		{
			return await _tipoFormaPagamentoRepository.ObterTodosAsync();
		}
	}
}
