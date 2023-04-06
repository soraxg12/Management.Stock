using Management.Socket.Domain.Entities;
using Management.Socket.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Management.Stock.Web.Controllers
{
    [Route("[controller]")]
    public class BrandController : Controller
    {
        private IBaseService<Brand> _BrandBaseService;
        private IBrandService _brandService;

        public BrandController(IBaseService<Brand> BrandBaseService, IBrandService brandService)
        {
            _BrandBaseService = BrandBaseService;
            _brandService = brandService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("create")]
        public IActionResult create()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult create(Brand brand)
        {
            _brandService.Add(brand);

            return View();
        }
    }
}
