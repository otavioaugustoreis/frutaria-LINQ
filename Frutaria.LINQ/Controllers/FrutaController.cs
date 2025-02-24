using Frutaria.LINQ.Interfaces;
using Frutaria.LINQ.Services;
using Microsoft.AspNetCore.Mvc;

namespace Frutaria.LINQ.Controllers
{


    [ApiController]
    [Route("[Controller]")]
    public class FrutaController : ControllerBase
    {

        private readonly IFrutaService _frutaService;

        public FrutaController(IFrutaService frutaService)
        {
            this._frutaService = frutaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetFrutas()
        {
            var frutas = await _frutaService.GetFrutas();
            return Ok(frutas);
        }

        [HttpGet("por-categoria/{categoriaId}")]
        public async Task<IActionResult> GetFrutasPorCategoria(int categoriaId)
        {
            var categoria = await _frutaService.GetCategoriaPorIdAsync(categoriaId);
            if (categoria == null)
            {
                return NotFound("Categoria não encontrada.");
            }

            var frutas = await _frutaService.GetFrutasPorCategoria(categoria);
            return Ok(frutas);
        }

        [HttpGet("por-categoria/{categoriaId}/contem-letra/{letra}")]
        public async Task<IActionResult> GetFrutaPorCategoriaContendoLetra(int categoriaId, string letra)
        {
            var categoria = await _frutaService.GetCategoriaPorIdAsync(categoriaId);
            if (categoria == null)
            {
                return NotFound("Categoria não encontrada.");
            }

            var frutas = await _frutaService.GetFrutaPorCategoriaContendoALetra(categoria, letra);
            return Ok(frutas);
        }

        [HttpGet("por-categoria/{categoriaId}/termina-com/{letra}")]
        public async Task<IActionResult> GetFrutaPorCategoriaTerminaComLetra(int categoriaId, string letra)
        {
            var categoria = await _frutaService.GetCategoriaPorIdAsync(categoriaId);
            if (categoria == null)
            {
                return NotFound("Categoria não encontrada.");
            }

            var frutas = await _frutaService.GetFrutaPorCategoriaETerminaComLetra(categoria, letra);
            return Ok(frutas);
        }

        [HttpGet("comeca-com/{letra}")]
        public async Task<IActionResult> GetFrutaPorComecoDaLetra(string letra)
        {
            var frutas = await _frutaService.GetFrutaPorComecoDaLetra(letra);
            return Ok(frutas);
        }

        [HttpGet("agrupadas-por-categoria")]
        public async Task<IActionResult> GetFrutaAgrupadaPorCategoria()
        {
            var frutas = await _frutaService.GetFrutaAgrupadaPorCategoriaOrdenadaPeloNomeCategoria();
            return Ok(frutas);
        }
    }
}
