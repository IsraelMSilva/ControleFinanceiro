using ControleFinanceiro.Application.Interfaces;
using ControleFinanceiro.Application.Services;
using Microsoft.AspNetCore.Mvc;
using static ControleFinanceiro.Application.DTOs.SaidaDTO;

namespace ControleFinanceiro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaidaController : ControllerBase
    {
        private readonly ISaidaService _saidaService;
        public SaidaController(ISaidaService saidaService)
        {
            _saidaService = saidaService;
        }

        [HttpGet("RetornaSaida")]
        public IActionResult RetornaSaida(Guid id)
        {
            return Ok(_saidaService.RetornaSaidaPorId(id).Result);
        }

        [HttpGet("RetornaTodos")]
        public IActionResult RetornaTodos()
        {
            return Ok(_saidaService.RetornaTodosSaida().Result);
        }

        [HttpPost]
        public IActionResult AdicionarSaida(AdicionarSaidaDTO adicionarSaidaDTO)
        {
            try
            {
                return Ok(_saidaService.AdicionarSaida(adicionarSaidaDTO).Result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

		//AtualizarSaidaDTO
		//AtualizarSaidaValorDTO
		//AtualizarSaidaTipoSaidaDTO
		//AtualizarSaidaTipoFormaPagamentoDTO
		//AtualizarSaidaDataVencimentoDTO
		//AtualizarSaidaObservacaoDTO
		//AtualizarSaidaParcelaDTO
		//RemoverSaida
	}
}
