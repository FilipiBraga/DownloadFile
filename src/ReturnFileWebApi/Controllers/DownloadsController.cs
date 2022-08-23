using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReturnFileWebApi.Interface;

namespace ReturnFileWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DownloadsController : ControllerBase
    {
        private readonly IFileService _fileService;

        public DownloadsController(IFileService fileService)
        {
            _fileService = fileService;
        }


        [HttpGet("image-stream")]
        public IActionResult ReturnStream()
        {
            var mimeType = "image/jpeg";

            var image = _fileService.GetImage();
            return File(image, mimeType, "teste.jpg");
        }

        [HttpGet("images-byte")]
        public IActionResult ReturnByte()
        {
            var mimeType = "application/octet-stream";

            var image = _fileService.GetImage(true);
            var retorno = File(image, mimeType, "teste.jpg");

            return retorno;
        }
    }
}
