using Management.Socket.Domain.Entities;
using Management.Socket.Domain.Interfaces;
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
        private IBaseService<Product> _productBaseService;
        public IActionResult Index()
        {
            return View();
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
           
            return View();
        }
    }
}
