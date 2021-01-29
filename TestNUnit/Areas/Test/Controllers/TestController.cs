using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TestNUnit.Areas.Test.Controllers
{
    [Area("Test")]
    [Route("[controller]/[action]")]
    public class TestController : Controller
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
