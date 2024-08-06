using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Application.DTOs
{
    public class TipoLancamentoDTO
    {
        public record AdicionarTipoLancamentoDTO(string Descricao, Guid IdTipoLancamento);
        public record AlterarTipoLancamentoDTO(Guid Id, string Descricao, Guid IdTipoLancamento);
        public record AlterarTipoLancamentoDescricaoDTO(Guid Id, string Descricao);
        public record AlterarTipoLancamentoIdTipoLancamentoDTO(Guid Id, Guid IdTipoLancamento);
    }
}
