using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace Jubilant.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult<string> Get() =>
            Ok("Hello Mario, the princess is in another catle.");
    }
}
