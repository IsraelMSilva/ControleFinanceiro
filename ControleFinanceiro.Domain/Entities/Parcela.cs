using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Domain.Entities
{
    public class Parcela
    {
		private Guid _id;
        private decimal _valorPago;
        private int _numeroParcela;
        private int _totalParcela;
        private DateTime _dataPagamento;
		 
        public Guid Id
		{
			get { return _id; }
			set { _id = value; }
		}

		public int TotalParcela
		{
			get { return _totalParcela; }
			set { _totalParcela = value; }
		}

		public int NumeroParcela
		{
			get { return _numeroParcela; }
			set { _numeroParcela = value; }
		}

		public decimal ValorPago
		{
			get { return _valorPago; }
			set { _valorPago = value; }
		}

		public DateTime DataPagamento
		{
			get { return _dataPagamento; }
			set { _dataPagamento = value; }
		}


	}
}
