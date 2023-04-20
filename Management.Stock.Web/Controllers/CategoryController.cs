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
    public class CategoryController : Controller
    {
        private IBaseService<Category> _CategoryBaseService;

        public CategoryController(IBaseService<Category> categoryBaseService)
        {
            _CategoryBaseService = categoryBaseService;
        }

        public IActionResult Index()
        {
            CategoryViewModel categoryViewModel = new CategoryViewModel();

            categoryViewModel.categories = _CategoryBaseService.Get();

            return View(categoryViewModel);
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
