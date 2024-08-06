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

		[HttpGet("RetornaTodos")]
		public IActionResult RetornaTodos()
		{
			return Ok(_tipoSaidaService.RetornaTodosTipoSaida().Result);
		}

		[HttpPost]
		public IActionResult AdicionarTipoSaida(AdicionarTipoSaidaDTO adicionarTipoSaidaDTO)
		{
			return Ok(_tipoSaidaService.AdicionarTipoSaida(adicionarTipoSaidaDTO).Result);
		}
	}
}
