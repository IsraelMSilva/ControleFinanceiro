using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Domain.Entities
{
    public class Credito
    {
        private Credito() { }

		private Guid _id;
        private Guid _idTipoCredito;
        private string _observacao;
        private decimal _valor;

        public Guid Id
		{
			get { return _id; }
			set { _id = value; }
		}

		public decimal Valor
		{
			get { return _valor; }
			set { _valor = value; }
		}

		public string Observacao
		{
			get { return _observacao; }
			set { _observacao = value; }
		}

		public Guid IdTipoCredito
		{
			get { return _idTipoCredito; }
			set { _idTipoCredito = value; }
		}

		public virtual TipoCredito TipoCredito { get; set; }
	}
}
