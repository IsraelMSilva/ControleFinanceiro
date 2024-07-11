using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Domain.Entities
{
    public class TipoFormaPagamento 
    {
        private Guid _id;
        private string? _descricao;
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

		public bool Ativo
		{
			get { return _ativo; }
			private set { _ativo = value; }
		}

		public static TipoFormaPagamento AdicionarFormaPagamento(string descricao)
		{
			if (string.IsNullOrWhiteSpace(descricao))
				throw new ArgumentNullException(nameof(descricao));

			TipoFormaPagamento tipoFormaPagamento = new() { Id = Guid.NewGuid(), Descricao = descricao };

			return tipoFormaPagamento;
		}

		public void AtualizarFormaPagamento(string descricao)
		{
            if (string.IsNullOrWhiteSpace(descricao))
                throw new ArgumentNullException(nameof(descricao));

            _descricao = descricao;
		}

		public void InativarTipoFormaPagamento()
		{
			_ativo = false;
		}
	}
}
