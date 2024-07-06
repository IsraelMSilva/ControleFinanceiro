using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Domain.Entities
{
    public class TipoSaida : Tipo
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

		public static TipoSaida AdicionarTipoSaida(string descricao)
		{
			if (string.IsNullOrWhiteSpace(descricao))
				throw new ArgumentNullException(nameof(descricao));

			TipoSaida tipoSaida = new() { Id = Guid.NewGuid(), Descricao = descricao };

			return tipoSaida;
		}

		public void AtualizarTipoSaida(string descricao)
		{
            if (string.IsNullOrWhiteSpace(descricao))
                throw new ArgumentNullException(nameof(descricao));

            
            _descricao = descricao;
		}

		public virtual IEnumerable<TipoCategoria>? TipoCategorias { get; set; }
    }
}
