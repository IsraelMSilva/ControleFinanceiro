using ControleFinanceiro.Application.Interfaces;
using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Domain.Repositories;
using ControleFinanceiro.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ControleFinanceiro.Application.DTOs.TipoLancamentoDTO;

namespace ControleFinanceiro.Application.Services
{
    public class TipoLancamentoService : ITipoLancamentoService
    {
        private readonly ITipoLancamentoRepository _tipoLancamentoRepository;

        public TipoLancamentoService(ITipoLancamentoRepository tipoLancamentoRepository)
        {
            _tipoLancamentoRepository = tipoLancamentoRepository;
        }

        public async Task<TipoLancamento> AdicionarTipoLancamento(AdicionarTipoLancamentoDTO adicionarTipoLancamentoDTO)
        {
            TipoLancamento tipoLancamento = TipoLancamento.AdicionarTipoLancamento(adicionarTipoLancamentoDTO.Descricao);
            return await _tipoLancamentoRepository.CriarAsync(tipoLancamento);
        }

        public async Task<TipoLancamento> AtualizarTipoLancamentoCompleto(AlterarTipoLancamentoDTO alterarTipoLancamentoDTO)
        {
            TipoLancamento retorno = await _tipoLancamentoRepository.ObterPorIdAsync(alterarTipoLancamentoDTO.Id);

            if (retorno == null)
                throw new Exception("Tipo de Lançamento não encontrada!");

            retorno.AtualizarTipoLancamento(alterarTipoLancamentoDTO.Descricao, alterarTipoLancamentoDTO.IdTipoLancamento);

            return await _tipoLancamentoRepository.AtualizarAsync(retorno);
        }

        public async Task<TipoLancamento> AtualizarTipoLancamentoDescricao(AlterarTipoLancamentoDescricaoDTO alterarTipoLancamentoDescricaoDTO)
        {
            TipoLancamento retorno = await _tipoLancamentoRepository.ObterPorIdAsync(alterarTipoLancamentoDescricaoDTO.Id);

            if (retorno == null)
                throw new Exception("Tipo Lançamento não encontrado!");

            retorno.AtualizarTipoLancamentoDescricao(alterarTipoLancamentoDescricaoDTO.Descricao);

            return await _tipoLancamentoRepository.AtualizarAsync(retorno);
        }

        public async Task<TipoLancamento> AtualizarTipoLancamentoIdTipoLancamento(AlterarTipoLancamentoIdTipoLancamentoDTO alterarTipoLancamentoIdTipoLancamentoDTO)
        {
            TipoLancamento retorno = await _tipoLancamentoRepository.ObterPorIdAsync(alterarTipoLancamentoIdTipoLancamentoDTO.Id);

            if (retorno == null)
                throw new Exception("Tipo Lançamento não encontrado!");

            retorno.AtualizarIdTipoLancamento(alterarTipoLancamentoIdTipoLancamentoDTO.IdTipoLancamento);

            return await _tipoLancamentoRepository.AtualizarAsync(retorno);
        }

        public async Task RemoverTipoLancamento(Guid id)
        {
            TipoLancamento retorno = await _tipoLancamentoRepository.ObterPorIdAsync(id);
            retorno.InativarTipoLancamento();
            await _tipoLancamentoRepository.AtualizarAsync(retorno);
        }

        public async Task<TipoLancamento> RetornaTipoLancamentoPorId(Guid id)
        {
            return await _tipoLancamentoRepository.ObterPorIdAsync(id);
        }

        public async Task<IEnumerable<TipoLancamento>> RetornaTipoLancamentoPorDescricao(string descricao)
        {
            if (string.IsNullOrEmpty(descricao))
                throw new Exception("Insira a descrição para buscar!");

            return await _tipoLancamentoRepository.ObterTipoLancamentoPorDescricao(descricao);
        }

        public async Task<IEnumerable<TipoLancamento>> RetornaTodosTipoLancamento()
        {
            return await _tipoLancamentoRepository.ObterTodosAsync();
        }
    }
}
