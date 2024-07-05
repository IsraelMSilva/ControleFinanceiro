using System;
using System.Collections.Generic;
using System.Drawing;
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

		public static Parcela CadastrarParcela(int totalParcela, int numeroParcela, decimal valorPago, DateTime dataPagamento)
		{
			if (totalParcela == 0)
				throw new ArgumentException("Informe o número total de parcelas");

			if (numeroParcela == 0)
				throw new ArgumentException("Informe o número da parcela");

			Parcela parcela = new() { Id = Guid.NewGuid(), TotalParcela = totalParcela, NumeroParcela = numeroParcela, ValorPago = valorPago, DataPagamento = dataPagamento};

			return parcela;
		}

		public void EditarParcela(int totalParcela, int numeroParcela, decimal valorPago, DateTime dataPagamento)
		{
			if (totalParcela == 0)
				throw new ArgumentException("Informe o número total de parcelas");

			if (numeroParcela == 0)
				throw new ArgumentException("Informe o número da parcela");

			//if (valorPago == 0)
			//	throw new ArgumentException("Informe o valor pago");

			//if (dataPagamento == DateTime.MinValue)
			//	throw new ArgumentException("Informe a data de pagamento");

			_totalParcela = totalParcela;
			_numeroParcela = numeroParcela;
			_valorPago = valorPago;
			_dataPagamento = dataPagamento;
		}

		public void EditarTotalParcela(int totalParcela)
		{
			if (totalParcela == 0)
				throw new ArgumentException("Informe o número total de parcelas");

			_totalParcela = totalParcela;
		}

		public void EditarNumeroParcela(int numeroParcela)
		{
			if (numeroParcela == 0)
				throw new ArgumentException("Informe o número da parcela");

			_numeroParcela = numeroParcela;
		}

		public void EditarValorPago(decimal valorPago)
		{
			//if (valorPago == 0)
			//	throw new ArgumentException("Informe o valor pago");

			_valorPago = valorPago;
		}

		public void EditarDataPagamento(DateTime dataPagamento)
		{
			//if (dataPagamento == DateTime.MinValue)
			//	throw new ArgumentException("Informe a data de pagamento");

			_dataPagamento = dataPagamento;
		}
	}
}
