using Microsoft.AspNetCore.Mvc;

namespace Management.Stock.Web.Controllers
{
    [Route("[controller]")]
    public class BrandController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("create")]
        public IActionResult create()
        {
            return View();
        }
    }
}
