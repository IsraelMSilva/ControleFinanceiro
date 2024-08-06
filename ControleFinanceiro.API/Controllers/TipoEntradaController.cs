using ControleFinanceiro.Application.DTOs;
using ControleFinanceiro.Application.Interfaces;
using ControleFinanceiro.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ControleFinanceiro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TipoEntradaController : ControllerBase
    {
        private readonly ITipoEntradaService _tipoEntradaService;
        public TipoEntradaController(ITipoEntradaService tipoEntradaService)
        {
            _tipoEntradaService = tipoEntradaService;
        }

        [HttpGet("RetornaTipoEntrada")]
        public IActionResult RetornaTipoEntrada(Guid id)
        {
            return Ok(_tipoEntradaService.RetornaTipoEntradaPorId(id).Result);
        }

        [HttpGet("RetornaTodos")]
        public IActionResult RetornaTodos()
        {
            return Ok(_tipoEntradaService.RetornaTodosTipoEntrada().Result);
        }

        [HttpPost]
        public IActionResult AdicionarTipoEntrada(TipoEntradaDTO.AdicionarTipoEntradaDTO adicionarTipoEntradaDTO)
        {
            return Ok(_tipoEntradaService.AdicionarTipoEntrada(adicionarTipoEntradaDTO).Result);
        }
    }
}
