using ControleFinanceiro.Application.DTOs;
using ControleFinanceiro.Application.Interfaces;
using ControleFinanceiro.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ControleFinanceiro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TipoFormaPagamentoController : ControllerBase
    {
        private readonly ITipoFormaPagamentoService _tipoFormaPagamentoService;
        public TipoFormaPagamentoController(ITipoFormaPagamentoService tipoFormaPagamentoService)
        {
            _tipoFormaPagamentoService = tipoFormaPagamentoService;
        }

        [HttpGet("RetornaTipoFormaPagamento")]
        public IActionResult RetornaTipoFormaPagamento(Guid id)
        {
            return Ok(_tipoFormaPagamentoService.RetornaTipoFormaPagamentoPorId(id).Result);
        }

        [HttpGet("RetornaTodos")]
        public IActionResult RetornaTodos()
        {
            return Ok(_tipoFormaPagamentoService.RetornaTodosTipoFormaPagamento().Result);
        }

        [HttpPost]
        public IActionResult AdicionarTipoFormaPagamento(TipoFormaPagamentoDTO.AdicionarTipoFormaPagamentoDTO adicionarTipoFormaPagamentoDTO)
        {
            return Ok(_tipoFormaPagamentoService.AdicionarTipoFormaPagamento(adicionarTipoFormaPagamentoDTO).Result);
        }

    }
}
