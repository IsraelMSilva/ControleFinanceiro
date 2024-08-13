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
		private readonly List<Usuario> _usuarios;
		public UsuarioMock()
		{
			_usuarios = [];
		}

		public Task<Usuario> AtualizarAsync(Usuario entity)
        {
			var usuario = _usuarios.First(a => a.Id == entity.Id);
			return Task.FromResult(usuario);
		}

        public Task<Usuario> CriarAsync(Usuario entity)
        {
			_usuarios.Add(entity);
			var usuario = _usuarios.First(a => a.Id == entity.Id);

			return Task.FromResult(usuario);
		}

        public Task DeletarAsync(Usuario entity)
        {
			_usuarios.Remove(entity);
			return Task.FromResult(entity);
		}

        public Task<Usuario> ObterPorIdAsync(Guid id)
        {
			var parcela = _usuarios.First(a => a.Id == id);
			return Task.FromResult(parcela);
		}

        public Task<IEnumerable<Usuario>> ObterTodosAsync()
        {
			return Task.FromResult(_usuarios.Where(a => a.Ativo));
		}

        public Task<IEnumerable<Usuario>> ObterUsuariosPorNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
