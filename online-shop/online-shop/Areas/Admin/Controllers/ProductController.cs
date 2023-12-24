using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using online_shop.DataAccess.Repository;
using online_shop.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace online_shop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // Get all products
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(_unitOfWork.Product.GetAll().ToList());
        }

        // Create product

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Product.Add(product);
                _unitOfWork.Save();
                return RedirectToAction("Index", "Product");
            }
            return NotFound();
        }

        // Edit
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Product product = _unitOfWork.Product.GetFirst(u => u.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {

            if (ModelState.IsValid)
            {
                _unitOfWork.Product.Add(product);
                _unitOfWork.Save();
                return RedirectToAction("Index", "Product");
            }
            return NotFound();
        }

        //Delete
        public IActionResult Delete(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            Product product = _unitOfWork.Product.GetFirst(u => u.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteProduct(int? id)
        {
            if (ModelState.IsValid)
            {
                Product product = _unitOfWork.Product.GetFirst(u => u.Id == id);
                if (product == null)
                {
                    return NotFound();
                }
                _unitOfWork.Product.Remove(product);

                _unitOfWork.Save();
                return RedirectToAction("Index", "Product");
            }
            return NotFound();
        }
    }
}

