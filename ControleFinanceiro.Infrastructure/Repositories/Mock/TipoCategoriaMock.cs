using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Infrastructure.Repositories.Mock
{
    public class TipoCategoriaMock : ITipoCategoriaRepository
    {
        private readonly List<TipoCategoria> _tipoCategorias;
        public TipoCategoriaMock()
        {
            _tipoCategorias = [];
        }
        public Task<TipoCategoria> AtualizarAsync(TipoCategoria entity)
        {
            var categoria = _tipoCategorias.First(a => a.Id == entity.Id);
            return Task.FromResult(categoria);
        }

        public Task<TipoCategoria> CriarAsync(TipoCategoria entity)
        {
            _tipoCategorias.Add(entity);
            var categoria = _tipoCategorias.First(a => a.Id == entity.Id);

            return Task.FromResult(categoria);
        }

        public Task DeletarAsync(TipoCategoria entity)
        {
            _tipoCategorias.Remove(entity);
            return Task.FromResult(entity);
        }

        public Task<TipoCategoria> ObterPorIdAsync(Guid id)
        {
            var categoria = _tipoCategorias.First(a => a.Id == id);
            return Task.FromResult(categoria);
        }

        public Task<IEnumerable<TipoCategoria>> ObterTipoCategoriaPorDescricao(string descricao)
        {
            return Task.FromResult(_tipoCategorias.Where(a => a.Descricao == descricao));
        }

        public Task<IEnumerable<TipoCategoria>> ObterTodosAsync()
        {
            return Task.FromResult(_tipoCategorias.Where(a => a.Descricao != null));
        }
    }
}
