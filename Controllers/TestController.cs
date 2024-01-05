using Microsoft.AspNetCore.Mvc;

namespace BlazorRenderTest.Controllers
{
    [Route("Test")]
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
