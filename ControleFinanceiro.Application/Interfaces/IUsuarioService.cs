using ControleFinanceiro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ControleFinanceiro.Application.DTOs.UsuarioDTO;

namespace ControleFinanceiro.Application.Interfaces
{
    public interface IUsuarioService
    {
        Task<Usuario> AdicionarUsuario(AdicionarUsuarioDTO adicionarUsuarioDTO);
        Task<Usuario> AtualizarUsuarioCompleto(AlterarUsuarioDTO alterarUsuarioDTO);
        Task<Usuario> AtualizarUsuarioNome(AlterarUsuarioNomeDTO alterarUsuarioNomeDTO);
        Task<Usuario> AtualizarUsuarioSenha(AlterarUsuarioSenhaDTO alterarUsuarioSenhaDTO);
        Task<Usuario> RetornaUsuarioPorId(Guid id);
        Task<IEnumerable<Usuario>> RetornaTodosOsUsuarios();
        Task<IEnumerable<Usuario>> RetornaUsuariosPorNome(string nome);
        Task RemoverUsuario(Guid id);
    }
}
