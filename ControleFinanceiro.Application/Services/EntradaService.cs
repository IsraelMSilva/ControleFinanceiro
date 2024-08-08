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
using static ControleFinanceiro.Application.DTOs.EntradaDTO;
using static ControleFinanceiro.Application.DTOs.SaidaDTO;

namespace ControleFinanceiro.Application.Services
{
    public class EntradaService : IEntradaService
    {
        private readonly IEntradaRepository _entradaRepository;
        private readonly ITipoEntradaRepository _tipoEntradaRepository;

        public EntradaService(IEntradaRepository entradaRepository,
                              ITipoEntradaRepository tipoEntradaRepository)
        {
            _entradaRepository = entradaRepository;
            _tipoEntradaRepository = tipoEntradaRepository;
        }

        public async Task<Entrada> AdicionarEntrada(AdicionarEntradaDTO adicionarEntradaDTO)
        {
            if (await _tipoEntradaRepository.ObterPorIdAsync(adicionarEntradaDTO.idTipoEntrada) is null)
                throw new ArgumentException("Tipo de entrada não encontrada.");

            Entrada entrada = Entrada.CadastrarEntrada(adicionarEntradaDTO.valor, adicionarEntradaDTO.observacao, adicionarEntradaDTO.idTipoEntrada);
            return await _entradaRepository.CriarAsync(entrada);
        }

        public async Task<Entrada> AtualizarEntrada(AtualizarEntradaDTO atualizarEntradaDTO)
        {
            Entrada retorno = await _entradaRepository.ObterPorIdAsync(atualizarEntradaDTO.Id);

            if (retorno == null)
                throw new Exception("Entrada não encontrada!");

            if (await _tipoEntradaRepository.ObterPorIdAsync(atualizarEntradaDTO.idTipoEntrada) is null)
                throw new ArgumentException("Tipo de entrada não encontrada.");

            retorno.EditarEntrada(atualizarEntradaDTO.valor, atualizarEntradaDTO.observacao, atualizarEntradaDTO.idTipoEntrada);

            return await _entradaRepository.AtualizarAsync(retorno);
        }

        public async Task<Entrada> AtualizarEntradaObservacao(AtualizarEntradaObservacaoDTO atualizarEntradaObservacaoDTO)
        {
            Entrada retorno = await _entradaRepository.ObterPorIdAsync(atualizarEntradaObservacaoDTO.Id);

            if (retorno == null)
                throw new Exception("Entrada não encontrada!");

            retorno.EditarObservacao(atualizarEntradaObservacaoDTO.observacao);

            return await _entradaRepository.AtualizarAsync(retorno);
        }
        public async Task<Entrada> AtualizarEntradaTipoEntrada(AtualizarEntradaTipoEntradaDTO atualizarEntradaTipoEntradaDTO)
        {
            Entrada retorno = await _entradaRepository.ObterPorIdAsync(atualizarEntradaTipoEntradaDTO.Id);

            if (retorno == null)
                throw new Exception("Entrada não encontrada!");

            retorno.EditarTipoEntrada(atualizarEntradaTipoEntradaDTO.idTipoEntrada);

            return await _entradaRepository.AtualizarAsync(retorno);
        }
        public async Task<Entrada> AtualizarEntradaValor(AtualizarEntradaValorDTO atualizarEntradaValorDTO)
        {
            Entrada retorno = await _entradaRepository.ObterPorIdAsync(atualizarEntradaValorDTO.Id);

            if (retorno == null)
                throw new Exception("Entrada não encontrada!");

            retorno.EditarValor(atualizarEntradaValorDTO.valor);

            return await _entradaRepository.AtualizarAsync(retorno);
        }
        public async Task RemoverEntrada(Guid id)
        {
            throw new NotImplementedException();
        }
        public async Task<Entrada> RetornaEntradaPorId(Guid id)
        {
            return await _entradaRepository.ObterPorIdAsync(id);
        }

        public async Task<IEnumerable<Entrada>> RetornaTodosEntrada()
        {
            return await _entradaRepository.ObterTodosAsync();
        }
    }
}
