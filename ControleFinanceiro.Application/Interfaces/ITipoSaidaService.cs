using ControleFinanceiro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ControleFinanceiro.Application.DTOs.TipoSaidaDTO;

namespace ControleFinanceiro.Application.Interfaces
{
	public interface ITipoSaidaService
	{
		Task<TipoSaida> AdicionarTipoSaida(AdicionarTipoSaidaDTO adicionarTipoSaidaDTO);
		Task<TipoSaida> AtualizarTipoSaida(AlterarTipoSaidaDTO alterarTipoSaidaDTO);
		Task<TipoSaida> RetornaTipoSaidaPorId(Guid id);
		Task<IEnumerable<TipoSaida>> RetornaTodosTipoSaida();
		Task<IEnumerable<TipoSaida>> RetornaTipoSaidaPorDescricao(string descricao);
		Task RemoverTipoSaida(Guid id);
	}
}
