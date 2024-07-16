using ControleFinanceiro.Application.DTOs;
using ControleFinanceiro.Application.Interfaces;
using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Domain.Repositories;
using ControleFinanceiro.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ControleFinanceiro.Application.DTOs.UsuarioDTO;


namespace ControleFinanceiro.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<Usuario> AdicionarUsuario(AdicionarUsuarioDTO adicionarUsuarioDTO)
        {
            Usuario usuario = Usuario.AdicionarUsuario(adicionarUsuarioDTO.Nome, adicionarUsuarioDTO.Senha);
            return await _usuarioRepository.CriarAsync(usuario);
        }

        public async Task<Usuario> AtualizarUsuarioCompleto(AlterarUsuarioDTO alterarUsuarioDTO)
        {
            var (id, nome, senha) = alterarUsuarioDTO;

            Usuario retorno = await _usuarioRepository.ObterPorIdAsync(id);

            if (retorno == null)
                throw new Exception("Usuário não encontrado!");

            retorno.AtualizarUsuarioCompleto(nome, senha);

            return await _usuarioRepository.AtualizarAsync(retorno);
        }

        public async Task<Usuario> AtualizarUsuarioNome(AlterarUsuarioNomeDTO alterarUsuarioNomeDTO)
        {
            Usuario retorno = await _usuarioRepository.ObterPorIdAsync(alterarUsuarioNomeDTO.Id);

            if (retorno == null)
                throw new Exception("Usuário não encontrado!");

            retorno.AtualizarUsuarioNome(alterarUsuarioNomeDTO.Nome);

            return await _usuarioRepository.AtualizarAsync(retorno);
        }

        public async Task<Usuario> AtualizarUsuarioSenha(AlterarUsuarioSenhaDTO alterarUsuarioSenhaDTO)
        {
            Usuario retorno = await _usuarioRepository.ObterPorIdAsync(alterarUsuarioSenhaDTO.Id);

            if (retorno == null)
                throw new Exception("Usuário não encontrado!");

            retorno.AtualizarUsuarioSenha(alterarUsuarioSenhaDTO.Senha);

            return await _usuarioRepository.AtualizarAsync(retorno);
        }

        public async Task RemoverUsuario(Guid id)
        {
            Usuario retorno = await _usuarioRepository.ObterPorIdAsync(id);
            retorno.DeletarUsuario();
            await _usuarioRepository.AtualizarAsync(retorno);
        }

        public async Task<IEnumerable<Usuario>> RetornaTodosOsUsuarios()
        {
            return await _usuarioRepository.ObterTodosAsync();
        }

        public async Task<Usuario> RetornaUsuarioPorId(Guid id)
        {
            return await _usuarioRepository.ObterPorIdAsync(id);
        }

        public async Task<IEnumerable<Usuario>> RetornaUsuariosPorNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
                throw new Exception("Insira o nome para buscar!");

            return await _usuarioRepository.ObterUsuariosPorNome(nome);
        }
    }
}
