﻿using System;
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

        public Guid IdSaida
        {
            get { return _idSaida; }
            set { _idSaida = value; }
        }

        public Guid IdEntrada
        {
            get { return _idEntrada; }
            set { _idEntrada = value; }
        }

        public virtual Saida Saida { get; set; }
        public virtual Entrada Entrada { get; set; }
        public virtual TipoLancamento TipoLancamento { get; set; }

    }
}
