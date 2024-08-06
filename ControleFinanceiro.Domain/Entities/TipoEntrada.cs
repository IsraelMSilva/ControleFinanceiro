using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Domain.Entities
{
    public class TipoEntrada 
    {
        private TipoEntrada() { }

        private Guid _id;
        private string _descricao;
        private bool _ativo;

        public Guid Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        public string Descricao
        {
            get { return _descricao; }
            private set { _descricao = value; }
        }

        public bool Ativo
        {
            get { return _ativo; }
            private set { _ativo = value; }
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

        public void InativarTipoEntrada()
        {
            _ativo = false;
        }
    }
}
