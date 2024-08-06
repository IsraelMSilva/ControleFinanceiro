using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Infrastructure.Repositories.Mock
{
    public class TipoFormaPagamentoMock : ITipoFormaPagamentoRepository
    {
        private readonly List<TipoFormaPagamento> _tipoFormaPagamento;
        public TipoFormaPagamentoMock()
        {
            _tipoFormaPagamento = [];
        }

        public Task<TipoFormaPagamento> AtualizarAsync(TipoFormaPagamento entity)
        {
            var tipoFormaPagamento = _tipoFormaPagamento.First(a => a.Id == entity.Id);
            return Task.FromResult(tipoFormaPagamento);
        }

        public Task<TipoFormaPagamento> CriarAsync(TipoFormaPagamento entity)
        {
            _tipoFormaPagamento.Add(entity);
            var tipoFormaPagamento = _tipoFormaPagamento.First(a => a.Id == entity.Id);

            return Task.FromResult(tipoFormaPagamento);
        }

        public Task DeletarAsync(TipoFormaPagamento entity)
        {
            _tipoFormaPagamento.Remove(entity);
            return Task.FromResult(entity);
        }

        public Task<TipoFormaPagamento> ObterPorIdAsync(Guid id)
        {
            var tipoFormaPagamento = _tipoFormaPagamento.First(a => a.Id == id);
            return Task.FromResult(tipoFormaPagamento);
        }

        public Task<IEnumerable<TipoFormaPagamento>> ObterTipoFormaPagamentoPorDescricao(string descricao)
        {
            return Task.FromResult(_tipoFormaPagamento.Where(a => a.Descricao == descricao));
        }

        public Task<IEnumerable<TipoFormaPagamento>> ObterTodosAsync()
        {
            return Task.FromResult(_tipoFormaPagamento.Where(a => a.Descricao != null));
        }
    }
}
