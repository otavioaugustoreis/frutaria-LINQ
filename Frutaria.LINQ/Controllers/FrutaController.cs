using Frutaria.LINQ.Services;
using Microsoft.AspNetCore.Mvc;

namespace Frutaria.LINQ.Controllers
{


    [ApiController]
    [Route("[Controller]")]
    public class FrutaController : ControllerBase
    {

        private readonly FrutaService frutaService;

        public FrutaController(FrutaService frutaService)
        {
            this.frutaService = frutaService;
        }
    }
}
