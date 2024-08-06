using ControleFinanceiro.Application.Interfaces;
using ControleFinanceiro.Application.Services;
using Microsoft.AspNetCore.Mvc;
using static ControleFinanceiro.Application.DTOs.ParcelaDTO;

namespace ControleFinanceiro.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ParcelaController : ControllerBase
	{
		private readonly IParcelaService _ParcelaService;
		public ParcelaController(IParcelaService parcelaService)
		{
			_ParcelaService = parcelaService;
		}

		[HttpGet("RetornaParcela")]
		public IActionResult RetornaParcela(Guid id)
		{
			return Ok(_ParcelaService.RetornaParcelaPorId(id).Result);
		}

		[HttpGet("RetornaTodos")]
		public IActionResult RetornaTodos()
		{
			return Ok(_ParcelaService.RetornaTodasParcelas().Result);
		}

		[HttpPost]
		public IActionResult AdicionarParcela(AdicionarParcelaDTO adicionarParcelaDTO)
		{
			return Ok(_ParcelaService.AdicionarParcela(adicionarParcelaDTO).Result);
		}
	}
}
