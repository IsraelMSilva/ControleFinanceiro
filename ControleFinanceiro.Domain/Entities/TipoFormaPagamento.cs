using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Domain.Entities
{
    public class TipoFormaPagamento : Tipo
    {
        private Guid _id;
        private string? _descricao;

        public override Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public override string? Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

		public static TipoFormaPagamento AdicionarFormaPagamento(string descricao)
		{
			if (string.IsNullOrWhiteSpace(descricao))
				throw new ArgumentNullException(nameof(descricao));

			TipoFormaPagamento tipoFormaPagamento = new() { Descricao = descricao };

			return tipoFormaPagamento;
		}

		public void AtualizarFormaPagamento(string descricao)
		{
			Descricao = descricao;
		}
	}
}
