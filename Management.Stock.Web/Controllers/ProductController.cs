using Management.Socket.Domain.Entities;
using Management.Socket.Domain.Interfaces;
using Management.Stock.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management.Stock.Web.Controllers
{
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly IBaseService<Product> _productBaseService;

        public ProductController(IBaseService<Product> productBaseService)
        {
            _productBaseService = productBaseService;
        }

        public IActionResult Index()
        {
            ProductViewModel productViewModel = new ProductViewModel();

            productViewModel.products = _productBaseService.Get();

            return View(productViewModel);
        }

        [HttpGet("create")]
        public IActionResult create()
        {
            return View(new Product());
        }
        
        [HttpPost("create")]
        public IActionResult create(Product product)
        {
            _productBaseService.Add(product);

            return RedirectToAction("index");
        }
    }
}
