﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Application.DTOs
{
    public class UsuarioDTO
    {
        public record AdicionarUsuarioDTO(string Nome, string Senha);
    }
}
