using Microsoft.AspNetCore.Mvc;
using Dealership.Models;
using System.Collections.Generic;
using System;


namespace Dealership.Controllers
{
  public class SearchController: Controller
  {
    [HttpGet("/searchform")]
    public ActionResult SearchForm()
    {
      return View();
    }

    [HttpPost("/searchform")]
    public ActionResult Create(int maxPrice, int maxMileage)
    {
      List<Car> carList = Car.WorthBuying(maxPrice,maxMileage);

 
      // ViewBag.matchList = Car.WorthBuying(maxPrice, maxMileage);
      // Car.MakeTestList();
      // System.Console.WriteLine(Car.OnTheLot.Count);
      Car testCar = new Car("test", 0, 0, "test");
      return View("Show", Car.TestList);
    }

    [HttpGet("/show")]
    public ActionResult Show(List<Car> carList)
    {
      System.Console.WriteLine(carList.Count);
      return View(carList);
    }

  }
}