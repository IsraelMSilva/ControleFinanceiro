using ControleFinanceiro.Application.DTOs;
using ControleFinanceiro.Application.Interfaces;
using ControleFinanceiro.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ControleFinanceiro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoLancamentoController : ControllerBase
    {
        private readonly ITipoLancamentoService _tipoLancamentoService;
        public TipoLancamentoController(ITipoLancamentoService tipoLancamentoService)
        {
            _tipoLancamentoService = tipoLancamentoService;
        }

        [HttpGet("RetornaTipoLancamento")]
        public IActionResult RetornaTipoCategoria(Guid id)
        {
            return Ok(_tipoLancamentoService.RetornaTipoLancamentoPorId(id).Result);
        }

        [HttpGet("RetornaTodos")]
        public IActionResult RetornaTodos()
        {
            return Ok(_tipoLancamentoService.RetornaTodosTipoLancamento().Result);
        }

        [HttpPost]
        public IActionResult AdicionarTipoLancamento(TipoLancamentoDTO.AdicionarTipoLancamentoDTO adicionarTipoLancamentoDTO)
        {
            return Ok(_tipoLancamentoService.AdicionarTipoLancamento(adicionarTipoLancamentoDTO).Result);
        }
    }
}
