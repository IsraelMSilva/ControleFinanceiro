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
using static ControleFinanceiro.Application.DTOs.LancamentoDTO;

namespace ControleFinanceiro.Application.Services
{
	public class LancamentoService : ILancamentoService
	{
		private readonly ILancamentoRepository _lancamentoRepository;
		private readonly ISaidaRepository _saidaRepository;
		private readonly IEntradaRepository _entradaRepository;
		private readonly ITipoLancamentoRepository _tipoLancamentoRepository;

		public LancamentoService(ILancamentoRepository lancamentoRepository,
							ISaidaRepository saidaRepository,
							IEntradaRepository entradaRepository,
							ITipoLancamentoRepository tipoLancamentoRepository)
		{
			_lancamentoRepository = lancamentoRepository;
			_saidaRepository = saidaRepository;
			_entradaRepository = entradaRepository;
			_tipoLancamentoRepository = tipoLancamentoRepository;
		}

		public async Task<Lancamento> AdicionarLancamento(AdicionarLancamentoDTO adicionarLancamentoDTO)
		{
			if (await _tipoLancamentoRepository.ObterPorIdAsync(adicionarLancamentoDTO.idTipoLancamento) is null)
				throw new ArgumentException("Não encontrado o tipo de lançamento");

			if (await _saidaRepository.ObterPorIdAsync(adicionarLancamentoDTO.idSaida) is null)
				throw new ArgumentException("Não encontrado a saída");

			if (await _entradaRepository.ObterPorIdAsync(adicionarLancamentoDTO.idEntrada) is null)
				throw new ArgumentException("Não encontrada a entrada");

			Lancamento lancamento = Lancamento.CadastrarLancamento(adicionarLancamentoDTO.dataLancamento, adicionarLancamentoDTO.idTipoLancamento, adicionarLancamentoDTO.idSaida, adicionarLancamentoDTO.idEntrada);
			return await _lancamentoRepository.CriarAsync(lancamento);
		}

		public async Task<Lancamento> AtualizarLancamento(AtualizarLancamentoDTO atualizarLancamentoDTO)
		{
			Lancamento retorno = await _lancamentoRepository.ObterPorIdAsync(atualizarLancamentoDTO.Id);

			if (retorno == null)
				throw new Exception("Lançamento não encontrado!");

			if (await _tipoLancamentoRepository.ObterPorIdAsync(atualizarLancamentoDTO.idTipoLancamento) is null)
				throw new ArgumentException("Não encontrado o tipo de lançamento");

			if (await _saidaRepository.ObterPorIdAsync(atualizarLancamentoDTO.idSaida) is null)
				throw new ArgumentException("Não encontrado a saída");

			if (await _entradaRepository.ObterPorIdAsync(atualizarLancamentoDTO.idEntrada) is null)
				throw new ArgumentException("Não encontrado a entrada");

			retorno.EditarLancamento(atualizarLancamentoDTO.dataLancamento, atualizarLancamentoDTO.idTipoLancamento, atualizarLancamentoDTO.idSaida, atualizarLancamentoDTO.idEntrada);

			return await _lancamentoRepository.AtualizarAsync(retorno);
		}

		public async Task<Lancamento> AtualizarLancamentoData(AtualizarLancamentoDataDTO atualizarLancamentoDataDTO)
		{
			Lancamento retorno = await _lancamentoRepository.ObterPorIdAsync(atualizarLancamentoDataDTO.Id);

			if (retorno == null)
				throw new Exception("Lançamento não encontrado!");

			retorno.EditarDataLancamento(atualizarLancamentoDataDTO.dataLancamento);

			return await _lancamentoRepository.AtualizarAsync(retorno);
		}

		public async Task<Lancamento> AtualizarLancamentoTipoLancamento(AtualizarLancamentoTipoLancamentoDTO atualizarLancamentoTipoLancamentoDTO)
		{
			Lancamento retorno = await _lancamentoRepository.ObterPorIdAsync(atualizarLancamentoTipoLancamentoDTO.Id);

			if (retorno == null)
				throw new Exception("Lançamento não encontrado!");

			if (await _tipoLancamentoRepository.ObterPorIdAsync(atualizarLancamentoTipoLancamentoDTO.idTipoLancamento) is null)
				throw new ArgumentException("Não encontrado o tipo de lançamento");

			if (await _saidaRepository.ObterPorIdAsync(atualizarLancamentoTipoLancamentoDTO.idSaida) is null)
				throw new ArgumentException("Não encontrado a saída");

			if (await _entradaRepository.ObterPorIdAsync(atualizarLancamentoTipoLancamentoDTO.idEntrada) is null)
				throw new ArgumentException("Não encontrado a entrada");

			retorno.EditarTipoLancamento(atualizarLancamentoTipoLancamentoDTO.idTipoLancamento, atualizarLancamentoTipoLancamentoDTO.idSaida, atualizarLancamentoTipoLancamentoDTO.idEntrada);

			return await _lancamentoRepository.AtualizarAsync(retorno);
		}

		public async Task RemoverLancamento(Guid id)
		{
			Lancamento retorno = await _lancamentoRepository.ObterPorIdAsync(id);
			retorno.InativarLancamento();
			await _lancamentoRepository.AtualizarAsync(retorno);
		}

		public async Task<Lancamento> RetornaLancamentoPorId(Guid id)
		{
			return await _lancamentoRepository.ObterPorIdAsync(id);
		}

		public async Task<IEnumerable<Lancamento>> RetornaTodosLancamento()
		{
			return await _lancamentoRepository.ObterTodosAsync();
		}
	}
}
