using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Application.DTOs
{
    public class TipoCategoriaDTO
    {
        public record AdicionarTipoCategoriaDTO(string Descricao, string IdTipoSaida);
        public record AlterarTipoCategoriaDTO(Guid Id, string Descricao, string IdTipoSaida);
        public record AlterarTipoCategoriaDescricaoDTO(Guid Id, string Descricao);
        public record AlterarTipoCategoriaIdTipoSaidaDTO(Guid Id, string IdTipoSaida);
    }
}
