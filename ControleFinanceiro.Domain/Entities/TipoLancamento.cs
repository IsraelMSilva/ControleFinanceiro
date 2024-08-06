using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Domain.Entities
{
    public class TipoLancamento
    {
        private TipoLancamento() { }

        private Guid _id;
        private string? _descricao;
        private Guid _idTipoLancamento;
        private bool _ativo;

		public Guid Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        public string? Descricao
        {
            get { return _descricao; }
            private set { _descricao = value; }
        }

        public Guid IdTipoLancamento
        {
            get { return _idTipoLancamento; }
            private set { _idTipoLancamento = value; }
        }

        public bool Ativo
		{
			get { return _ativo; }
			private set { _ativo = value; }
		}

		public static TipoLancamento AdicionarTipoLancamento(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
                throw new ArgumentNullException(nameof(descricao));

            TipoLancamento tipoLancamento = new() { Id = Guid.NewGuid(), Descricao = descricao };

            return tipoLancamento;
        }

        public void AtualizarTipoLancamento(string descricao, Guid idTipoLancamento)
        {
            _idTipoLancamento = idTipoLancamento;
            _descricao = descricao;
        }

		public void InativarTipoLancamento()
		{
			_ativo = false;
		}

        public void AtualizarTipoLancamentoDescricao(string descricao)
        {
            _descricao = descricao;
        }
        public void AtualizarIdTipoLancamento(Guid idTipoLancamento)
        {
            _idTipoLancamento = idTipoLancamento;
        }
    }
}
