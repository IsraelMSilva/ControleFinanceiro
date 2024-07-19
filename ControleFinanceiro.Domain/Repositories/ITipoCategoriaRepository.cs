using ControleFinanceiro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Domain.Repositories
{
    public interface ITipoCategoriaRepository : IRepositoryCrud<TipoCategoria>
    {
        Task<IEnumerable<TipoCategoria>> ObterTipoCategoriaPorDescricao(string descricao);
    }
}
