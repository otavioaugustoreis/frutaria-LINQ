using Frutaria.LINQ.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Frutaria.LINQ.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    public class CategoriaController : ControllerBase
    {

        private readonly ICategoriaService categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            this.categoriaService = categoriaService;
        }

    }
}
