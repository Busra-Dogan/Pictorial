using Microsoft.AspNetCore.Mvc;
using Pictorial.Business.Abstract;
using Pictorial.Entities.Concrete;

namespace Pictorial.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorityController : Controller
    {
        IAuthorityService _authorityService;
        public AuthorityController(IAuthorityService authorityService)
        {
            _authorityService = authorityService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _authorityService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Authority authority)
        {
            var result = _authorityService.Add(authority);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Authority authority)
        {
            var result = _authorityService.Delete(authority);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
