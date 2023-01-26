using Aflevering1.Data.Models;
using Aflevering1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using System.ComponentModel.DataAnnotations;

namespace Aflevering1.Controllers
{
    public class ShoppingListController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public ShoppingListController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var shopLists = _dbContext.ShoppingLists.ToList();
            return View(shopLists);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Shoppinglist shoppinglist)
        {
            _dbContext.ShoppingLists.Add(shoppinglist);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var shoppingList = _dbContext.ShoppingLists.Find(id);
            return View(shoppingList);
        }
        [HttpPost]
        public IActionResult Edit(Shoppinglist shoppinglist)
        {
            _dbContext.ShoppingLists.Update(shoppinglist);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            var shoppingList = _dbContext.ShoppingLists.Find(id);
            if (shoppingList == null)
            {
                return NotFound();
            }
            return View(shoppingList);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var shoppingList = _dbContext.ShoppingLists.Find(id);
            _dbContext.ShoppingLists.Remove(shoppingList);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var shoppingList = _dbContext.ShoppingLists.Find(id);
            return View(shoppingList);
        }
    }
}
