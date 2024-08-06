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
using static ControleFinanceiro.Application.DTOs.TipoCategoriaDTO;


namespace ControleFinanceiro.Application.Services
{
	public class TipoCategoriaService : ITipoCategoriaService
	{
		private readonly ITipoCategoriaRepository _tipoCategoriaRepository;
		public TipoCategoriaService(ITipoCategoriaRepository tipoCategoriaRepository)
		{
			_tipoCategoriaRepository = tipoCategoriaRepository;
		}

		public async Task<TipoCategoria> AdicionarTipoCategoria(AdicionarTipoCategoriaDTO adicionarTipoCategoriaDTO)
		{
            TipoCategoria tipoCategoria = TipoCategoria.AdicionarTipoCategoria(adicionarTipoCategoriaDTO.Descricao);
			return await _tipoCategoriaRepository.CriarAsync(tipoCategoria);
		}

		public async Task<TipoCategoria> AtualizarTipoCategoriaCompleto(AlterarTipoCategoriaDTO alterarTipoCategoriaDTO)
		{
			TipoCategoria retorno = await _tipoCategoriaRepository.ObterPorIdAsync(alterarTipoCategoriaDTO.Id);

			if (retorno == null)
				throw new Exception("Tipo de Categoria não encontrada!");

			retorno.AtualizarTipoCategoria(alterarTipoCategoriaDTO.Descricao, alterarTipoCategoriaDTO.IdTipoSaida);

			return await _tipoCategoriaRepository.AtualizarAsync(retorno);
		}

		public async Task<TipoCategoria> AtualizarTipoCategoriaDescricao(AlterarTipoCategoriaDescricaoDTO alterarTipoCategoriaDescricaoDTO)
		{
			TipoCategoria retorno = await _tipoCategoriaRepository.ObterPorIdAsync(alterarTipoCategoriaDescricaoDTO.Id);

			if (retorno == null)
				throw new Exception("Tipo Categoria não encontrado!");

			retorno.AtualizarTipoCategoriaDescricao(alterarTipoCategoriaDescricaoDTO.Descricao);

			return await _tipoCategoriaRepository.AtualizarAsync(retorno);
		}

		public async Task<TipoCategoria> AtualizarTipoCategoriaIdTipoSaida(AlterarTipoCategoriaIdTipoSaidaDTO alterarTipoCategoriaIdTipoSaidaDTO)
		{
			TipoCategoria retorno = await _tipoCategoriaRepository.ObterPorIdAsync(alterarTipoCategoriaIdTipoSaidaDTO.Id);

			if (retorno == null)
				throw new Exception("Tipo Categoria não encontrado!");

			retorno.AtualizarIdTipoSaida(alterarTipoCategoriaIdTipoSaidaDTO.IdTipoSaida);

			return await _tipoCategoriaRepository.AtualizarAsync(retorno);
		}

		public async Task RemoverTipoCategoria(Guid id)
		{
			TipoCategoria retorno = await _tipoCategoriaRepository.ObterPorIdAsync(id);
			retorno.InativarTipoCategoria();
			await _tipoCategoriaRepository.AtualizarAsync(retorno);
		}

		public async Task<TipoCategoria> RetornaTipoCategoriaIdPorId(Guid id)
		{
			return await _tipoCategoriaRepository.ObterPorIdAsync(id);
		}

		public async Task<IEnumerable<TipoCategoria>> RetornaTipoCategoriaPorDescricao(string descricao)
		{
			if (string.IsNullOrEmpty(descricao))
				throw new Exception("Insira a descrição para buscar!");

			return await _tipoCategoriaRepository.ObterTipoCategoriaPorDescricao(descricao);
		}

		public async Task<IEnumerable<TipoCategoria>> RetornaTodosTipoCategoria()
		{
			return await _tipoCategoriaRepository.ObterTodosAsync();
		}
	}
}
