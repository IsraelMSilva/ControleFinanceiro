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
using static ControleFinanceiro.Application.DTOs.SaidaDTO;

namespace ControleFinanceiro.Application.Services
{
    public class SaidaService : ISaidaService
    {
        private readonly ISaidaRepository _saidaRepository;
        private readonly ITipoSaidaRepository _tipoSaidaRepository;
        private readonly ITipoFormaPagamentoRepository _tipoFormaPagamentoRepository;
        private readonly IParcelaRepository _parcelaRepository;

        public SaidaService(ISaidaRepository saidaRepository, 
                            ITipoSaidaRepository tipoSaidaRepository,
                            ITipoFormaPagamentoRepository tipoFormaPagamentoRepository, 
                            IParcelaRepository parcelaRepository)
        {
            _saidaRepository = saidaRepository;
            _tipoSaidaRepository = tipoSaidaRepository;
            _tipoFormaPagamentoRepository = tipoFormaPagamentoRepository;
            _parcelaRepository = parcelaRepository;
        }

        public async Task<Saida> AdicionarSaida(AdicionarSaidaDTO adicionarSaidaDTO)
        {
            if (await _tipoSaidaRepository.ObterPorIdAsync(adicionarSaidaDTO.idTipoSaida) is null)
                throw new ArgumentException("Não encontrado o tipo saida");

            if (await _tipoFormaPagamentoRepository.ObterPorIdAsync(adicionarSaidaDTO.idTipoFormaPagamento) is null)
                throw new ArgumentException("Não encontrado o tipo de forma de pagamento");

            if (await _parcelaRepository.ObterPorIdAsync(adicionarSaidaDTO.idParcela) is null)
                throw new ArgumentException("Não encontrada parcela");

            Saida saida = Saida.CadastrarSaida(adicionarSaidaDTO.valor, adicionarSaidaDTO.idTipoSaida, adicionarSaidaDTO.idTipoFormaPagamento, adicionarSaidaDTO.dataVencimento, adicionarSaidaDTO.observacao, adicionarSaidaDTO.idParcela);
            return await _saidaRepository.CriarAsync(saida);
        }

        public async Task<Saida> AtualizarSaida(AtualizarSaidaDTO atualizarSaidaDTO)
        {
            Saida retorno = await _saidaRepository.ObterPorIdAsync(atualizarSaidaDTO.Id);

            if (retorno == null)
                throw new Exception("Saída não encontrada!");

            if (await _tipoSaidaRepository.ObterPorIdAsync(atualizarSaidaDTO.idTipoSaida) is null)
                throw new ArgumentException("Não encontrado o tipo saida");

            if (await _tipoFormaPagamentoRepository.ObterPorIdAsync(atualizarSaidaDTO.idTipoFormaPagamento) is null)
                throw new ArgumentException("Não encontrado o tipo de forma de pagamento");

            if (await _parcelaRepository.ObterPorIdAsync(atualizarSaidaDTO.idParcela) is null)
                throw new ArgumentException("Não encontrada parcela");

            retorno.EditarSaida(atualizarSaidaDTO.valor, atualizarSaidaDTO.idTipoSaida, atualizarSaidaDTO.idTipoFormaPagamento, atualizarSaidaDTO.dataVencimento, atualizarSaidaDTO.observacao, atualizarSaidaDTO.idParcela);

            return await _saidaRepository.AtualizarAsync(retorno);
        }

        public async Task<Saida> AtualizarSaidaDataVencimento(AtualizarSaidaDataVencimentoDTO atualizarSaidaDataVencimentoDTO)
        {
            Saida retorno = await _saidaRepository.ObterPorIdAsync(atualizarSaidaDataVencimentoDTO.Id);

            if (retorno == null)
                throw new Exception("Saída não encontrada!");

            retorno.EditarDataVencimento(atualizarSaidaDataVencimentoDTO.dataVencimento);

            return await _saidaRepository.AtualizarAsync(retorno);
        }

        public async Task<Saida> AtualizarSaidaObservacao(AtualizarSaidaObservacaoDTO atualizarSaidaObservacaoDTO)
        {
            Saida retorno = await _saidaRepository.ObterPorIdAsync(atualizarSaidaObservacaoDTO.Id);

            if (retorno == null)
                throw new Exception("Saída não encontrada!");

            retorno.EditarObservacao(atualizarSaidaObservacaoDTO.observacao);

            return await _saidaRepository.AtualizarAsync(retorno);
        }

        public async Task<Saida> AtualizarSaidaParcela(AtualizarSaidaParcelaDTO atualizarSaidaParcelaDTO)
        {
            Saida retorno = await _saidaRepository.ObterPorIdAsync(atualizarSaidaParcelaDTO.Id);

            if (retorno == null)
                throw new Exception("Saída não encontrada!");

            retorno.EditarParcela(atualizarSaidaParcelaDTO.idParcela);

            return await _saidaRepository.AtualizarAsync(retorno);
        }

        public async Task<Saida> AtualizarSaidaTipoFormaPagamento(AtualizarSaidaTipoFormaPagamentoDTO atualizarSaidaTipoFormaPagamentoDTO)
        {
            Saida retorno = await _saidaRepository.ObterPorIdAsync(atualizarSaidaTipoFormaPagamentoDTO.Id);

            if (retorno == null)
                throw new Exception("Saída não encontrada!");

            retorno.EditarTipoFormaPagamento(atualizarSaidaTipoFormaPagamentoDTO.idTipoFormaPagamento);

            return await _saidaRepository.AtualizarAsync(retorno);
        }

        public async Task<Saida> AtualizarSaidaTipoSaida(AtualizarSaidaTipoSaidaDTO atualizarSaidaTipoSaidaDTO)
        {
            Saida retorno = await _saidaRepository.ObterPorIdAsync(atualizarSaidaTipoSaidaDTO.Id);

            if (retorno == null)
                throw new Exception("Saída não encontrada!");

            retorno.EditarTipoSaida(atualizarSaidaTipoSaidaDTO.idTipoSaida);

            return await _saidaRepository.AtualizarAsync(retorno);
        }

        public async Task<Saida> AtualizarSaidaValor(AtualizarSaidaValorDTO atualizarSaidaValorDTO)
        {
            Saida retorno = await _saidaRepository.ObterPorIdAsync(atualizarSaidaValorDTO.Id);

            if (retorno == null)
                throw new Exception("Saída não encontrada!");

            retorno.EditarValor(atualizarSaidaValorDTO.valor);

            return await _saidaRepository.AtualizarAsync(retorno);
        }

        public async Task RemoverSaida(Guid id)
        {
            Saida retorno = await _saidaRepository.ObterPorIdAsync(id);
            retorno.InativarSaida();
            await _saidaRepository.AtualizarAsync(retorno);
        }

        public async Task<Saida> RetornaSaidaPorId(Guid id)
        {
            return await _saidaRepository.ObterPorIdAsync(id);
        }

        public async Task<IEnumerable<Saida>> RetornaTodosSaida()
        {
            return await _saidaRepository.ObterTodosAsync();
        }
    }
}
