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
using static ControleFinanceiro.Application.DTOs.TipoEntradaDTO;

namespace ControleFinanceiro.Application.Services
{
    public class TipoEntradaService : ITipoEntradaService
    {
        private readonly ITipoEntradaRepository _tipoEntradaRepository;

        public TipoEntradaService(ITipoEntradaRepository tipoEntradaRepository)
        {
            _tipoEntradaRepository = tipoEntradaRepository;
        }

        public async Task<TipoEntrada> AdicionarTipoEntrada(AdicionarTipoEntradaDTO adicionarTipoEntradaDTO)
        {
            TipoEntrada tipoEntrada = TipoEntrada.AdicionarTipoEntrada(adicionarTipoEntradaDTO.Descricao);
            return await _tipoEntradaRepository.CriarAsync(tipoEntrada);
        }

        public async Task<TipoEntrada> AtualizarTipoEntrada(AlterarTipoEntradaDTO alterarTipoEntradaDTO)
        {
            TipoEntrada retorno = await _tipoEntradaRepository.ObterPorIdAsync(alterarTipoEntradaDTO.Id);

            if (retorno == null)
                throw new Exception("Tipo de Sáida não encontrada!");

            retorno.AtualizarTipoEntrada(alterarTipoEntradaDTO.Descricao);

            return await _tipoEntradaRepository.AtualizarAsync(retorno);
        }

        public async Task RemoverTipoEntrada(Guid id)
        {
            TipoEntrada retorno = await _tipoEntradaRepository.ObterPorIdAsync(id);
            retorno.InativarTipoEntrada();
            await _tipoEntradaRepository.AtualizarAsync(retorno);
        }

        public async Task<IEnumerable<TipoEntrada>> RetornaTipoEntradaPorDescricao(string descricao)
        {
            if (string.IsNullOrEmpty(descricao))
                throw new Exception("Insira a descrição para buscar!");

            return await _tipoEntradaRepository.ObterTipoEntradaPorDescricao(descricao);
        }

        public async Task<TipoEntrada> RetornaTipoEntradaPorId(Guid id)
        {
            return await _tipoEntradaRepository.ObterPorIdAsync(id);
        }

        public async Task<IEnumerable<TipoEntrada>> RetornaTodosTipoEntrada()
        {
            return await _tipoEntradaRepository.ObterTodosAsync();
        }
    }
}
