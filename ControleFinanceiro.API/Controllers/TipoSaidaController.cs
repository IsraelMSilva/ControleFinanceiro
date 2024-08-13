using ControleFinanceiro.Application.DTOs;
using ControleFinanceiro.Application.Interfaces;
using ControleFinanceiro.Application.Services;
using Microsoft.AspNetCore.Mvc;
using static ControleFinanceiro.Application.DTOs.TipoSaidaDTO;

namespace ControleFinanceiro.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TipoSaidaController : ControllerBase
	{
		private readonly ITipoSaidaService _tipoSaidaService;
		public TipoSaidaController(ITipoSaidaService tipoSaidaService)
		{
			_tipoSaidaService = tipoSaidaService;
		}

		[HttpGet("RetornaTipoSaida")]
		public IActionResult RetornaTipoSaida(Guid id)
		{
			return Ok(_tipoSaidaService.RetornaTipoSaidaPorId(id).Result);
		}

		[HttpGet("RetornaTipoSaidaDescricao")]
		public IActionResult RetornaTipoSaidaDescricao(string descricao)
		{
			//.Where(a => a.Descricao.Contains(descricao) && a.Ativo)
			return Ok(_tipoSaidaService.RetornaTipoSaidaPorDescricao(descricao).Result);
		}

		[HttpGet("RetornaTodos")]
		public IActionResult RetornaTodos()
		{
			return Ok(_tipoSaidaService.RetornaTodosTipoSaida().Result);
		}

		[HttpPost]
		public IActionResult AdicionarTipoSaida(AdicionarTipoSaidaDTO adicionarTipoSaidaDTO)
		{
			try
			{
				return Ok(_tipoSaidaService.AdicionarTipoSaida(adicionarTipoSaidaDTO).Result);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		//[HttpPost]
		//public IActionResult AtualizarTipoSaida(AlterarTipoSaidaDTO alterarTipoSaidaDTO)
		//{
		//	try
		//	{
		//		return Ok(_tipoSaidaService.AtualizarTipoSaida(alterarTipoSaidaDTO).Result);
		//	}
		//	catch (Exception ex)
		//	{
		//		return BadRequest(ex.Message);
		//	}
		//}

		//RemoverTipoSaida
	}
}
