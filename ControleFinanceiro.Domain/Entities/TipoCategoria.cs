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
        private Guid _idTipoSaida;

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

        public Guid IdTipoSaida
        {
            get { return _idTipoSaida; }
            set { _idTipoSaida = value; }
        }

        public virtual TipoSaida? TipoSaida { get; set; }

        public static TipoCategoria AdicionarTipoCategoria(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
                throw new ArgumentNullException(nameof(descricao));

            TipoCategoria tipoCategoria = new() { Id = Guid.NewGuid(), Descricao = descricao };

            return tipoCategoria;
        }

        public void AtualizarTipoCategoria(string descricao)
        {
            _descricao = descricao;
        }

    }
}
