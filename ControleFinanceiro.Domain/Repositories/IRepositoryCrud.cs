using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Domain.Repositories
{
    public interface IRepositoryCrud<T> where T : class
    {
        Task<T> CriarAsync(T entity);
        Task<T> AtualizarAsync(T entity);
        Task DeletarAsync(T entity);
        Task<IEnumerable<T>> ObterTodosAsync();
        Task<T> ObterPorIdAsync(Guid id);
    }
}
