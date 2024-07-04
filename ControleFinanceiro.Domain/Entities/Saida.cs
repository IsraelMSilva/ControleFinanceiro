using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Domain.Entities
{
    public class Saida
    {
        private Saida() { }

		private Guid _id;
        private Guid _idTipoSaida;
        private decimal _valor;
        private Guid _idTipoFormaPagamento;
        private DateTime _dataVencimento;
        private string _observacao;
        private Guid _idParcela;

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

		public Guid IdTipoSaida
        {
			get { return _idTipoSaida; }
			set { _idTipoSaida = value; }
		}

		public Guid IdTipoFormaPagamento
		{
			get { return _idTipoFormaPagamento; }
			set { _idTipoFormaPagamento = value; }
		}

		public DateTime DataVencimento
		{
			get { return _dataVencimento; }
			set { _dataVencimento = value; }
		}

		public string Observacao
		{
			get { return _observacao; }
			set { _observacao = value; }
		}

		public Guid IdParcela
		{
			get { return _idParcela; }
			set { _idParcela = value; }
		}

		public virtual Parcela Parcela { get; set; }
		public virtual TipoSaida TipoSaida { get; set; }
		public virtual TipoFormaPagamento FormaPagamento { get; set;}
	
	}
}
