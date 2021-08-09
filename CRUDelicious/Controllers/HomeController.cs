using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using CRUDelicious.Models;
using System.Linq;
// Other using statements
namespace Monsters.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
     
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            _context = context;
        }
     
        [HttpGet("")]
        public IActionResult Index()
        {
            return View(_context.Dishes.OrderBy(dish => dish.Name));
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            return View();
        }

        [HttpGet("{dishId}")]
        public IActionResult ShowDish(int dishId)
        {
            Dish model = _context.Dishes.FirstOrDefault(dish => dish.DishId == dishId);
            if(model == null)
                return RedirectToAction("Index");
            return View(model);
        }

        [HttpGet("{dishId}/edit")]
        public IActionResult Edit(int dishId)
        {
            Dish model = _context.Dishes.FirstOrDefault(dish => dish.DishId == dishId);
            if(model == null)
                return RedirectToAction("Index");
            return View(model);
        }

        [HttpPost("create")]
        public IActionResult Create(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                _context.Dishes.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("New");
        }

        [HttpPost("{dishId}/update")]
        public IActionResult Update(Dish dish, int dishId)
        {
            Dish dishUpdate = _context.Dishes.FirstOrDefault(dish => dish.DishId == dishId);
            if(ModelState.IsValid)
            {
                dishUpdate.Name = dish.Name;
                dishUpdate.Chef = dish.Chef;
                dishUpdate.Tastiness = dish.Tastiness;
                dishUpdate.Calories = dish.Calories;
                dishUpdate.Description = dish.Description;
                dishUpdate.UpdatedAt = DateTime.Now;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Edit", dish);
        }

        [HttpGet("{dishId}/delete")]
        public IActionResult Delete(int dishId)
        {
            Dish dishDelete = _context.Dishes.FirstOrDefault(dish => dish.DishId == dishId);
            if(dishDelete == null)
                return RedirectToAction("Index");
            _context.Dishes.Remove(dishDelete);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
 }