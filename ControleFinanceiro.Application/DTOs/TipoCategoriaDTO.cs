using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Application.DTOs
{
    public class TipoCategoriaDTO
    {
        public record AdicionarTipoCategoriaDTO(string Descricao, Guid IdTipoSaida);
        public record AlterarTipoCategoriaDTO(Guid Id, string Descricao, Guid IdTipoSaida);
        public record AlterarTipoCategoriaDescricaoDTO(Guid Id, string Descricao);
        public record AlterarTipoCategoriaIdTipoSaidaDTO(Guid Id, Guid IdTipoSaida);
    }
}
