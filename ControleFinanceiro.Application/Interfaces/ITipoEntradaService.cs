using ControleFinanceiro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ControleFinanceiro.Application.DTOs.TipoEntradaDTO;

namespace ControleFinanceiro.Application.Interfaces
{
    public interface ITipoEntradaService
    {
        Task<TipoEntrada> AdicionarTipoEntrada(AdicionarTipoEntradaDTO adicionarTipoEntradaDTO);
        Task<TipoEntrada> AtualizarTipoEntrada(AlterarTipoEntradaDTO alterarTipoEntradaDTO);
        Task<TipoEntrada> RetornaTipoEntradaPorId(Guid id);
        Task<IEnumerable<TipoEntrada>> RetornaTodosTipoEntrada();
        Task<IEnumerable<TipoEntrada>> RetornaTipoEntradaPorDescricao(string descricao);
        Task RemoverTipoEntrada(Guid id);
    }
}
