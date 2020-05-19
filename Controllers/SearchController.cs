using Microsoft.AspNetCore.Mvc;
using Dealership.Models;
using System.Collections.Generic;

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
      return View("Show", carList);
    }

    [HttpGet("/show")]
    public ActionResult Show(List<Car> carList)
    {
      return View(carList);
    }

  }
}