using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Domain.Entities
{
    public class Lancamento
    {
        private Lancamento() { }

		private Guid _id;
        private DateTime _data;
        private Guid _tipoLancamentoId;
        private Guid _idDespesa;
        private Guid _idCredito;

        public Guid Id
		{
			get { return _id; }
			set { _id = value; }
		}

		public DateTime Data
		{
			get { return _data; }
			set { _data = value; }
		}

		public Guid TipoLancamentoId
		{
			get { return _tipoLancamentoId; }
			set { _tipoLancamentoId = value; }
		}

		public Guid IdDespesa
		{
			get { return _idDespesa; }
			set { _idDespesa = value; }
		}

		public Guid IdCredito 
		{
			get { return _idCredito; }
			set { _idCredito = value; }
		}

		public virtual Despesa Despesa { get; set; }
		public virtual Credito Credito { get; set; }
		public virtual TipoLancamento TipoLancamento { get; set; }

    }
}
