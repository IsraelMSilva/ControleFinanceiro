using ControleFinanceiro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ControleFinanceiro.Application.DTOs.TipoCategoriaDTO;

namespace ControleFinanceiro.Application.Interfaces
{
    public interface ITipoCategoriaService
    {
        Task<TipoCategoria> AdicionarTipoCategoria(AdicionarTipoCategoriaDTO adicionarTipoCategoriaDTO);
        Task<TipoCategoria> AtualizarTipoCategoriaCompleto(AlterarTipoCategoriaDTO alterarTipoCategoriaDTO);
        Task<TipoCategoria> AtualizarTipoCategoriaDescricao(AlterarTipoCategoriaDescricaoDTO alterarTipoCategoriaDescricaoDTO);
        Task<TipoCategoria> AtualizarTipoCategoriaIdTipoSaida(AlterarTipoCategoriaIdTipoSaidaDTO alterarTipoCategoriaIdTipoSaidaDTO);
        Task<TipoCategoria> RetornaTipoCategoriaIdPorId(Guid id);
        Task<IEnumerable<TipoCategoria>> RetornaTodosTipoCategoria();
        Task<IEnumerable<TipoCategoria>> RetornaTipoCategoriaPorDescricao(string descricao);
        Task RemoverTipoCategoria(Guid id);
    }
}
