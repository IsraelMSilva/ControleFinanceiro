﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Domain.Entities
{
    public class TipoCategoria : Tipo
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

        private Guid _idTipoDespesa;

        public Guid IdTipoDespesa
        {
            get { return _idTipoDespesa; }
            set { _idTipoDespesa = value; }
        }

        public virtual TipoDespesa? TipoDespesa { get; set; }

    }
}
