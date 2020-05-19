using System;
using System.Collections.Generic;

namespace Dealership.Models
{
  public class Car
  {
    public string MakeModel {get; set;}
    public int Price {get; set;}
    public int Miles {get; set;}
    public string Description {get; set;}
    private static List<Car> _allCars = new List<Car> {};

    public Car(string makeModel, int price, int miles, string description)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Description = description;
      _allCars.Add(this);
    }

    public bool WorthBuying(int maxPrice, int maxMileage)
    {
      return (Price < maxPrice && Miles < maxMileage);
    }

    public static List<Car> GetAll()
    {
      return _allCars;
    }
    
    public static void ClearAll()
    {
      _allCars.Clear();
    }
  
  
  }
}
