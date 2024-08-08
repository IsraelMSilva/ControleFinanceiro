using ControleFinanceiro.Application.Interfaces;
using ControleFinanceiro.Application.Services;
using Microsoft.AspNetCore.Mvc;
using static ControleFinanceiro.Application.DTOs.EntradaDTO;
using static ControleFinanceiro.Application.DTOs.SaidaDTO;

namespace ControleFinanceiro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntradaController : ControllerBase
    {
        private readonly IEntradaService _entradaService;
        public EntradaController(IEntradaService entradaService)
        {
            _entradaService = entradaService;
        }

        [HttpGet("RetornaEntrada")]
        public IActionResult RetornaEntrada(Guid id)
        {
            return Ok(_entradaService.RetornaEntradaPorId(id).Result);
        }

        [HttpGet("RetornaTodos")]
        public IActionResult RetornaTodos()
        {
            return Ok(_entradaService.RetornaTodosEntrada().Result);
        }

        [HttpPost]
        public IActionResult AdicionarEntrada(AdicionarEntradaDTO adicionarEntradaDTO)
        {
            try
            {
                return Ok(_entradaService.AdicionarEntrada(adicionarEntradaDTO).Result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
