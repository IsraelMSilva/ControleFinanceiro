using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Domain.Entities
{
    public class TipoLancamento : Tipo
    {
        private TipoLancamento() { }

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

		public static TipoLancamento AdicionarTipoLancamento(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
                throw new ArgumentNullException(nameof(descricao));

            TipoLancamento tipoLancamento = new() { Id = Guid.NewGuid(), Descricao = descricao };

            return tipoLancamento;
        }

        public void AtualizarTipoLancamento(string descricao)
        {
            _descricao = descricao;
        }

		public void InativarTipoLancamento()
		{
			_ativo = false;
		}
	}
}
