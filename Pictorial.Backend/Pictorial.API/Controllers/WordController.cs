using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pictorial.Business.Abstract;
using Pictorial.Entities.Concrete;

namespace Pictorial.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordController : ControllerBase
    {
        IWordService _wordService;
        public WordController(IWordService wordService)
        {
            _wordService = wordService;
        }

        [HttpGet("getbycourseid")]
        public IActionResult GetAllByCourseId(int id)
        {
            var result = _wordService.GetAllByCourseId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Word word)
        {
            var result = _wordService.Add(word);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Word word)
        {
            var result = _wordService.Delete(word);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Word word)
        {
            var result = _wordService.Update(word);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
