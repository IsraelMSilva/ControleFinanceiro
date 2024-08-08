using ControleFinanceiro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ControleFinanceiro.Application.DTOs.EntradaDTO;

namespace ControleFinanceiro.Application.Interfaces
{
    public interface IEntradaService
    {
        Task<Entrada> AdicionarEntrada(AdicionarEntradaDTO adicionarEntradaDTO);
        Task<Entrada> AtualizarEntrada(AtualizarEntradaDTO atualizarEntradaDTO);
        Task<Entrada> AtualizarEntradaValor(AtualizarEntradaValorDTO atualizarEntradaValorDTO);
        Task<Entrada> AtualizarEntradaTipoEntrada(AtualizarEntradaTipoEntradaDTO atualizarEntradaTipoEntradaDTO);
        Task<Entrada> AtualizarEntradaObservacao(AtualizarEntradaObservacaoDTO atualizarEntradaObservacaoDTO);
        Task<Entrada> RetornaEntradaPorId(Guid id);
        Task<IEnumerable<Entrada>> RetornaTodosEntrada();
        Task RemoverEntrada(Guid id);
    }
}
