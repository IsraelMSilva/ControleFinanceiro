using ControleFinanceiro.Application.DTOs;
using ControleFinanceiro.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ControleFinanceiro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoCategoriaController : ControllerBase
    {
        private readonly ITipoCategoriaService _tipoCategoriaService;
        public TipoCategoriaController(ITipoCategoriaService tipoCategoriaService)
        {
            _tipoCategoriaService = tipoCategoriaService;
        }

        [HttpGet("RetornaTipoCategoria")]
        public IActionResult RetornaTipoCategoria(Guid id)
        {
            return Ok(_tipoCategoriaService.RetornaTipoCategoriaIdPorId(id).Result);
        }

        [HttpGet("RetornaTodos")]
        public IActionResult RetornaTodos()
        {
            return Ok(_tipoCategoriaService.RetornaTodosTipoCategoria().Result);
        }

        [HttpPost]
        public IActionResult AdicionarTipoCategoria(TipoCategoriaDTO.AdicionarTipoCategoriaDTO adicionarTipoCategoriaDTO)
        {
            return Ok(_tipoCategoriaService.AdicionarTipoCategoria(adicionarTipoCategoriaDTO).Result);
        }
    }
}
