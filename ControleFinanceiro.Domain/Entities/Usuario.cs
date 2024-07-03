using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Domain.Entities
{
    public class Usuario
    {
        private Usuario() { }

        private Guid _id;
        private string _nome;
        private string _senha;
        private bool _ativo;

        public static Usuario AdicionarUsuario(string nome, string senha)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new Exception("Informe o nome");

            if (string.IsNullOrWhiteSpace(senha))
                throw new Exception("Informe a senha");

            Usuario usuario = new() { _id = Guid.NewGuid(), _nome = nome, _senha = senha, _ativo = true };

            return usuario;
        }

        public void AtualizarUsuarioCompleto(string nome, string senha)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new Exception("Informe o nome");

            if (string.IsNullOrWhiteSpace(senha))
                throw new Exception("Informe a senha");

            _nome = nome;
            _senha = senha;
        }

        public void AtualizarUsuarioNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new Exception("Informe o nome");

            _nome = nome;
        }

        public void AtualizarUsuarioSenha(string senha)
        {

            if (string.IsNullOrWhiteSpace(senha))
                throw new Exception("Informe a senha");

            _senha = senha;
        }

        public void DeletarUsuario()
        {
            _ativo = false;
        }

        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }


        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }


        public bool Ativo
        {
            get { return _ativo; }
            set { _ativo = value; }
        }

    }
}
