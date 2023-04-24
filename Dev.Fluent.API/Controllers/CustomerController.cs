using Dev.Fluent.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dev.Fluent.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpPost("Add")]
        public IActionResult Add([FromBody] Customer customer)
        {
            if(!ModelState.IsValid)
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);
            
            return StatusCode(StatusCodes.Status200OK, "Model is valid!");
        }
    }
}
