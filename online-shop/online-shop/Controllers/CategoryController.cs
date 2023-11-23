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

        // Read/Get


        public IActionResult Index()
        {
            List<Category> categoryList = _db.Categories.ToList();
            foreach(Category cat in _db.Categories)
            {
                Console.WriteLine($"c print category: !{cat.Name}  + {cat.DisplayOrder}");
            }


            return View(categoryList);
        }

        // Create

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (category.DisplayOrder.ToString() == category.Name)
            {
                ModelState.AddModelError("Name", "The display order and name are same!");
            }

            if (ModelState.IsValid)
            {
                _db.Categories.Add(category);
                _db.SaveChanges();
                SetTempData("success", "add");
                return RedirectToAction("Index", "Category");
            }

            return View();
            
        }

        // Edit

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category category = _db.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(category);
                _db.SaveChanges();
                SetTempData("success", "edit");
                return RedirectToAction("Index", "Category");
            }

            return View();

        }

        // Edit

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category category = _db.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Category obj = _db.Categories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(obj);
            _db.SaveChanges();
            SetTempData("success", "delete");
            return RedirectToAction("Index");

        }

        void SetTempData(string key, string action)
        {
            // example: tempdata[success] = "Category update success"
            TempData[key] = $"Category {action} {key}";
        }
    }
}

