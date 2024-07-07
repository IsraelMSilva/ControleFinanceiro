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
		private bool _ativo;

		public Guid Id
		{
			get { return _id; }
			private set { _id = value; }
		}

		public decimal Valor
		{
			get { return _valor; }
			private set { _valor = value; }
		}

		public Guid IdTipoSaida
        {
			get { return _idTipoSaida; }
			private set { _idTipoSaida = value; }
		}

		public Guid IdTipoFormaPagamento
		{
			get { return _idTipoFormaPagamento; }
			private set { _idTipoFormaPagamento = value; }
		}

		public DateTime DataVencimento
		{
			get { return _dataVencimento; }
			private set { _dataVencimento = value; }
		}

		public string Observacao
		{
			get { return _observacao; }
			private set { _observacao = value; }
		}

		public Guid IdParcela
		{
			get { return _idParcela; }
			private set { _idParcela = value; }
		}

		public bool Ativo
		{
			get { return _ativo; }
			private set { _ativo = value; }
		}

		public virtual Parcela Parcela { get; set; }
		public virtual TipoSaida TipoSaida { get; set; }
		public virtual TipoFormaPagamento FormaPagamento { get; set; }

		public static Saida CadastrarSaida(decimal valor, Guid idTipoSaida, Guid idTipoFormaPagamento, DateTime dataVencimento, string observacao, Guid idParcela)
		{
			if(valor == 0)
				throw new ArgumentException("Informe o valor");

			if (dataVencimento == DateTime.MinValue)
				throw new ArgumentException("Informe a data de vencimento");

			Saida saida = new() { Id = Guid.NewGuid(), Valor = valor, IdTipoSaida = idTipoSaida, IdTipoFormaPagamento = idTipoFormaPagamento, DataVencimento = dataVencimento,  Observacao = observacao, IdParcela = idParcela };

			return saida;
		}

		public void EditarSaida(decimal valor, Guid idTipoSaida, Guid idTipoFormaPagamento, DateTime dataVencimento, string observacao, Guid idParcela)
		{
			if (valor == 0)
				throw new ArgumentException("Informe o valor");

			if (dataVencimento == DateTime.MinValue)
				throw new ArgumentException("Informe a data de vencimento");

			_valor = valor;
			_idTipoSaida = idTipoSaida;
			_idTipoFormaPagamento = idTipoFormaPagamento;
			_dataVencimento = dataVencimento;
			_observacao = observacao;
			_idParcela = idParcela;
		}

		public void EditarValor(decimal valor)
		{
			if (valor == 0)
				throw new ArgumentException("Informe o valor");

			_valor = valor;
		}

		public void EditarTipoSaida(Guid idTipoSaida)
		{
			_idTipoSaida = idTipoSaida;
		}

		public void EditarTipoFormaPagamento(Guid idTipoFormaPagamento)
		{
			_idTipoFormaPagamento = idTipoFormaPagamento;
		}

		public void EditarDataVencimento(DateTime dataVencimento)
		{
			if (dataVencimento == DateTime.MinValue)
				throw new ArgumentException("Informe a data de vencimento");

			_dataVencimento = dataVencimento;
		}

		public void EditarObservacao(string observacao)
		{
			_observacao = observacao;
		}

		public void EditarParcela(Guid idParcela)
		{
			_idParcela = idParcela;
		}

		public void InativarSaida()
		{
			_ativo = false;
		}
	}
}
