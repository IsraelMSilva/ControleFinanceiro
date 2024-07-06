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
        private Guid _idSaida;
        private Guid _idEntrada;
        private bool _ativo;

        public Guid Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        public DateTime Data
        {
            get { return _data; }
            private set { _data = value; }
        }

        public Guid TipoLancamentoId
        {
            get { return _tipoLancamentoId; }
            private set { _tipoLancamentoId = value; }
        }

        public Guid IdSaida
        {
            get { return _idSaida; }
            private set { _idSaida = value; }
        }

        public Guid IdEntrada
        {
            get { return _idEntrada; }
            private set { _idEntrada = value; }
        }

        public bool Ativo
        {
            get { return _ativo; }
            private set { _ativo = value; }
        }

        public virtual Saida Saida { get; set; }
        public virtual Entrada Entrada { get; set; }
        public virtual TipoLancamento TipoLancamento { get; set; }

        public static Lancamento CadastrarLancamento(DateTime dataLancamento, Guid idTipoLancamento, Guid idSaida, Guid idEntrada)
        {
            if (dataLancamento == DateTime.MinValue)
                throw new ArgumentException("Informe a data do lançamento");

            Lancamento lancamento = new() { Id = Guid.NewGuid(), Data = dataLancamento, TipoLancamentoId = idTipoLancamento, IdSaida = idSaida, IdEntrada = idEntrada, Ativo = true };

            return lancamento;
        }

        public void EditarLancamento(DateTime dataLancamento, Guid idTipoLancamento, Guid idSaida, Guid idEntrada)
        {
            if (dataLancamento == DateTime.MinValue)
                throw new ArgumentException("Informe a data do lançamento");

            _data = dataLancamento;
            _tipoLancamentoId = idTipoLancamento;
            _idSaida = idSaida;
            _idEntrada = idEntrada;
        }

        public void EditarDataLancamento(DateTime dataLancamento)
        {
            if (dataLancamento == DateTime.MinValue)
                throw new ArgumentException("Informe a data de vencimento");

            _data = dataLancamento;
        }

        public void EditarTipoLancamento(Guid idTipoLancamento, Guid idSaida, Guid idEntrada)
        {
            _tipoLancamentoId = idTipoLancamento;
            _idSaida = idSaida;
            _idEntrada = idEntrada;
        }

        public void InativarLancamento()
        {
            _ativo = false;
        }
    }
}
