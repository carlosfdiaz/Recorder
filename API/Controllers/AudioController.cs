using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AudioController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult("hello");
        }

        [HttpPost("uploadaudio")]
        public IActionResult UploadAudio([FromForm] IFormFile file)
        {
            if (file.ContentType != "audio/mp4")
            {
                return BadRequest("not an audio file.");
            }

            return Ok("received");
        }
    }
}
