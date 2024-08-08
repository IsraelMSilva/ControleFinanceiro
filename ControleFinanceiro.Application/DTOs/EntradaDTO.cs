using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Application.DTOs
{
    public class EntradaDTO
    {
        public record AdicionarEntradaDTO(decimal valor, Guid idTipoEntrada, string observacao);
        public record AtualizarEntradaDTO(Guid Id, decimal valor, Guid idTipoEntrada, string observacao);
        public record AtualizarEntradaValorDTO(Guid Id, decimal valor);
        public record AtualizarEntradaTipoEntradaDTO(Guid Id, Guid idTipoEntrada);
        public record AtualizarEntradaObservacaoDTO(Guid Id, string observacao);
    }
}