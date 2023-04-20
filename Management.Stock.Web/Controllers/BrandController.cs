using Management.Socket.Domain.Entities;
using Management.Socket.Domain.Interfaces;
using Management.Stock.Web.Models;
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
            BrandViewModel brandViewModel = new BrandViewModel();
            brandViewModel.brands = _BrandBaseService.Get();

            return View(brandViewModel);
        }

        [HttpGet("create")]
        public IActionResult create()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult create(Brand brand)
        {
            _BrandBaseService.Add(brand);

            return RedirectToAction("index");
        }
    }
}
