using Management.Socket.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management.Stock.Web.Controllers
{
    [Route("[controller]")]
    public class CategoryController : Controller
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

        [HttpPost("create")]
        public IActionResult create(Category category)
        {
            return View();
        }
    }
}
