using GroceryShop.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {    
        private readonly GroceryShopContext context;

        public ProductsController(GroceryShopContext context)
        {
            this.context = context;
        }

        // GET /admin/productss
        public async Task<IActionResult> Index()
        {
            return View(await context.Products.OrderByDescending(x => x.Id).Include(x => x.Category).ToListAsync());
        }

        // GET /admin/products/create
        public IActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(context.Categories.OrderBy(x => x.Sorting), "Id", "Name");

            return View();
        }
    }
}
