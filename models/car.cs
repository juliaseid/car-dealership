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
    private static List<Car> _worthBuying = new List<Car> {};

    public Car(string makeModel, int price, int miles, string description)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Description = description;
      _allCars.Add(this);
    }

    public static List<Car> WorthBuying(int maxPrice, int maxMileage)
    {
      foreach (Car car in _allCars) 
      {
        if (car.Price < maxPrice && car.Miles < maxMileage)
        
        _worthBuying.Add(car);
      }
      return _worthBuying;
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
