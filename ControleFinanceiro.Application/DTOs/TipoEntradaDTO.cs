using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Application.DTOs
{
    public class TipoEntradaDTO
    {
        public record AdicionarTipoEntradaDTO(string Descricao);
        public record AlterarTipoEntradaDTO(Guid Id, string Descricao);
    }
}
