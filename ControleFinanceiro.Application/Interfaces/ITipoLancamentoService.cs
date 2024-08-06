using ControleFinanceiro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ControleFinanceiro.Application.DTOs.TipoCategoriaDTO;
using static ControleFinanceiro.Application.DTOs.TipoLancamentoDTO;

namespace ControleFinanceiro.Application.Interfaces
{
    public interface ITipoLancamentoService
    {
        Task<TipoLancamento> AdicionarTipoLancamento(AdicionarTipoLancamentoDTO adicionarTipoLancamentoDTO);
        Task<TipoLancamento> AtualizarTipoLancamentoCompleto(AlterarTipoLancamentoDTO alterarTipoLancamentoDTO);
        Task<TipoLancamento> AtualizarTipoLancamentoDescricao(AlterarTipoLancamentoDescricaoDTO alterarTipoLancamentoDescricaoDTO);
        Task<TipoLancamento> AtualizarTipoLancamentoIdTipoLancamento(AlterarTipoLancamentoIdTipoLancamentoDTO alterarTipoLancamentoIdTipoLancamentoDTO);
        Task<TipoLancamento> RetornaTipoLancamentoPorId(Guid id);
        Task<IEnumerable<TipoLancamento>> RetornaTodosTipoLancamento();
        Task<IEnumerable<TipoLancamento>> RetornaTipoLancamentoPorDescricao(string descricao);
        Task RemoverTipoLancamento(Guid id);
    }
}
