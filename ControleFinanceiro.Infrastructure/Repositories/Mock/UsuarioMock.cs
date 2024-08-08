using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Infrastructure.Repositories.Mock
{
    public class UsuarioMock : IUsuarioRepository
    {
        public Task<Usuario> AtualizarAsync(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> CriarAsync(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public Task DeletarAsync(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> ObterPorIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuario>> ObterTodosAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuario>> ObterUsuariosPorNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
