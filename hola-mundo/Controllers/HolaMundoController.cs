using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace hola_mundo.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class HolaMundoController : Controller
    {

        [HttpGet]
        public  IActionResult GetHolaMundo()
        {
            return StatusCode(201, "Hola mundo");
        }
    }
}
