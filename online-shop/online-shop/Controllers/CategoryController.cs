using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using online_shop.Data;
using online_shop.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace online_shop.Controllers
{
    public class CategoryController : Controller
    {
        readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            List<Category> categoryList = _db.Categories.ToList();
            foreach(Category cat in _db.Categories)
            {
                Console.WriteLine($"c print category: !{cat.Name}  + {cat.DisplayOrder}");
            }


            return View(categoryList);
        }
    }
}

