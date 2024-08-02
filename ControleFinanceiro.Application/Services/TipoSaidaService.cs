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
using static ControleFinanceiro.Application.DTOs.TipoSaidaDTO;

namespace ControleFinanceiro.Application.Services
{
	public class TipoSaidaService : ITipoSaidaService
	{
		private readonly ITipoSaidaRepository  _tipoSaidaRepository;
		public TipoSaidaService(ITipoSaidaRepository tipoSaidaRepository)
		{
			_tipoSaidaRepository = tipoSaidaRepository;
		}

		public async Task<TipoSaida> AdicionarTipoSaida(AdicionarTipoSaidaDTO adicionarTipoSaidaDTO)
		{
			TipoSaida tipoSaida = TipoSaida.AdicionarTipoSaida(adicionarTipoSaidaDTO.Descricao);
			return await _tipoSaidaRepository.CriarAsync(tipoSaida);
		}

		public async Task<TipoSaida> AtualizarTipoSaida(AlterarTipoSaidaDTO alterarTipoSaidaDTO)
		{
			TipoSaida retorno = await _tipoSaidaRepository.ObterPorIdAsync(alterarTipoSaidaDTO.Id);

			if (retorno == null)
				throw new Exception("Tipo de Sáida não encontrada!");

			retorno.AtualizarTipoSaida(alterarTipoSaidaDTO.Descricao);

			return await _tipoSaidaRepository.AtualizarAsync(retorno);
		}

		public async Task RemoverTipoSaida(Guid id)
		{
			TipoSaida retorno = await _tipoSaidaRepository.ObterPorIdAsync(id);
			retorno.InativarTipoSaida();
			await _tipoSaidaRepository.AtualizarAsync(retorno);
		}

		public async Task<IEnumerable<TipoSaida>> RetornaTipoSaidaPorDescricao(string descricao)
		{
			if (string.IsNullOrEmpty(descricao))
				throw new Exception("Insira a descrição para buscar!");

			return await _tipoSaidaRepository.ObterTipoSaidaPorDescricao(descricao);
		}

		public async Task<TipoSaida> RetornaTipoSaidaPorId(Guid id)
		{
			return await _tipoSaidaRepository.ObterPorIdAsync(id);
		}

		public async Task<IEnumerable<TipoSaida>> RetornaTodosTipoSaida()
		{
			return await _tipoSaidaRepository.ObterTodosAsync();
		}
	}
}
