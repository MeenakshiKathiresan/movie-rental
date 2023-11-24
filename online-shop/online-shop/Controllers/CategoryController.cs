using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using online_shop.Data;
using online_shop.Models;
using online_shop.DataAccess.Repository.IRepository;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace online_shop.Controllers
{
    public class CategoryController : Controller
    {
        readonly ICategoryRepository _categoryRepo;

        public CategoryController(ICategoryRepository db)
        {
            _categoryRepo = db;
        }

        // Read/Get


        public IActionResult Index()
        {
            List<Category> categoryList = _categoryRepo.GetAll().ToList();
            foreach(Category cat in _categoryRepo.GetAll())
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
                _categoryRepo.Add(category);
                _categoryRepo.Save();
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
            Category category = _categoryRepo.GetFirst(u=>u.Id == id);
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
                _categoryRepo.Update(category);
                _categoryRepo.Save();
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
            Category category = _categoryRepo.GetFirst(u => u.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Category obj = _categoryRepo.GetFirst(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _categoryRepo.Remove(obj);
            _categoryRepo.Save();
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

