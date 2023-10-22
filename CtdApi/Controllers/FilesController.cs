using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions;

namespace CtdApi.Controllers
{
    [Route("api/[controller]")]
    public class FilesController : Controller
    {
        [HttpGet("parameters")]
        public ActionResult< LoginResponse> GetParameterFiles()
        {
            // Todo* Implement logic to return the list of parameter files
            return Ok(new LoginResponse { Username = "test", Token = "test-token" });
        }

        [HttpGet("parameters/download")]
        public ActionResult<IAsyncronousEnable<Byte>> DownloadParameterFiles()
        {
            // Todo: Implement logic to download parameter files in chunks
            return new Byte[] { 01};
        }

        [HttpPost("logs")]
        public ActionResult<IasynchronousEnable<Byte>> UploadLogsFiles(IFormFile file)
        {
            // Todo* Implement logic to receive and process log files in chunks
            return new Byte[] { 01};
        }
    }
}