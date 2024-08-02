using ControleFinanceiro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Domain.Repositories
{
    public interface ITipoEntradaRepository : IRepositoryCrud<TipoEntrada>
    {
        Task<IEnumerable<TipoEntrada>> ObterTipoEntradaPorDescricao(string descricao);
    }
}
