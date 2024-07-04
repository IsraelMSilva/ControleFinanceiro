using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Domain.Entities
{
    public class Entrada
    {
        private Entrada() { }

        private Guid _id;
        private Guid _idTipoEntrada;
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

        public Guid IdTipoEntrada
        {
            get { return _idTipoEntrada; }
            set { _idTipoEntrada = value; }
        }

        public static Entrada CadastrarEntrada(decimal valor, string observacao, Guid idTipoEntrada)
        {

            if (valor == 0)
                throw new ArgumentException("Informe o valor");


            Entrada entrada = new() { Id = Guid.NewGuid(), Valor = valor, IdTipoEntrada = idTipoEntrada, Observacao = observacao };

            return entrada;
        }

        public void EditarEntrada(decimal valor, string observacao, Guid idTipoEntrada)
        {
            if (valor == 0)
                throw new ArgumentException("Informe o valor");

            _valor = valor;
            _observacao = observacao;
            _idTipoEntrada = idTipoEntrada;
        }

        public virtual TipoEntrada TipoEntrada { get; set; }
    }
}
