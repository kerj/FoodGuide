using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using FoodGuide.Models;
using System;

namespace FoodGuide.Controllers
{
  public class CuisineController : Controller
  {

    [HttpGet("/cuisine")]
    public ActionResult Index()
    {
      List<Cuisine> allCuisines = Cuisine.GetAll();
      return View(allCuisines);
    }

    // [HttpGet("/cuisine/{id}")]
    // public ActionResult Index(int id)
    // {
    //   List<Restaurant> allRestaurants = Restaurant.GetCuisineList(id);
    //   return View("~/Restaurant/", allRestaurants);
    // }

    // [HttpPost("/cuisine/{id}/delete")]
    // public ActionResult Destroy(int id)
    // {
    //   Cuisine.RemoveHellBeast(id);
    //   return RedirectToAction("Index");
    // }
  }
}

//@"SELECT name FROM city WHERE cuisineId='" + id +"';";
