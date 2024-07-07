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
		private bool _ativo;

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

		public bool Ativo
		{
			get { return _ativo; }
			private set { _ativo = value; }
		}

		public virtual IEnumerable<TipoCategoria>? TipoCategorias { get; set; }

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

		public void InativarTipoSaida()
		{
			_ativo = false;
		}
    }
}
