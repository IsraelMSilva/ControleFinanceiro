using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Domain.Entities
{
    public class TipoEntrada : Tipo
    {
        private TipoEntrada() { }

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

        public static TipoEntrada AdicionarTipoEntrada(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
                throw new ArgumentNullException(nameof(descricao));

            TipoEntrada tipoEntrada = new() { Id = Guid.NewGuid(), Descricao = descricao };

            return tipoEntrada;
        }

        public void AtualizarTipoEntrada(string descricao)
        {
            _descricao = descricao;
        }
    }
}
