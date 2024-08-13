using ControleFinanceiro.Application.Interfaces;
using ControleFinanceiro.Application.Services;
using Microsoft.AspNetCore.Mvc;
using static ControleFinanceiro.Application.DTOs.LancamentoDTO;
using static ControleFinanceiro.Application.DTOs.SaidaDTO;

namespace ControleFinanceiro.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LancamentoController : ControllerBase
	{
		private readonly ILancamentoService _LancamentoService;
		public LancamentoController(ILancamentoService lancamentoService)
		{
			_LancamentoService = lancamentoService;
		}

		[HttpGet("RetornaLancamento")]
		public IActionResult RetornaSaida(Guid id)
		{
			return Ok(_LancamentoService.RetornaLancamentoPorId(id).Result);
		}

		[HttpGet("RetornaTodos")]
		public IActionResult RetornaTodos()
		{
			return Ok(_LancamentoService.RetornaTodosLancamento().Result);
		}

		[HttpPost]
		public IActionResult AdicionarLancamento(AdicionarLancamentoDTO adicionarLancamentoDTO)
		{
			try
			{
				return Ok(_LancamentoService.AdicionarLancamento(adicionarLancamentoDTO).Result);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		//AtualizarLancamentoDTO
		//AtualizarLancamentoDataDTO
		//AtualizarLancamentoTipoLancamentoDTO
		//RemoverLancamento
	}
}
