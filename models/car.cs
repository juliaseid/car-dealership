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
    public static List<Car> TestList = new List<Car> {};

    public Car(string makeModel, int price, int miles, string description)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Description = description;
      _allCars.Add(this);
      TestList = MakeTestList();
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
  
    public static List<Car> MakeTestList()
    {
      Car Car1 = new Car("Geo Metro", 75, 200000, "It runs, but you can't register it!");
      Car Car2 = new Car("Ford Escort", 400, 180000, "Busted alternator");
      Car Car3 = new Car("Jeep Wrangler", 1300, 275000, "Smells like mildew and sour milk");
      Car Car4 = new Car("Mercury Pacer", 2000, 350000, "Vintage!");
      List<Car> OnTheLot = new List<Car>{};
      OnTheLot.Add(Car1);
      OnTheLot.Add(Car2);
      OnTheLot.Add(Car3);
      OnTheLot.Add(Car4);
      return OnTheLot;
      // _allCars.Add(Car1);
      // _allCars.Add(Car2);
      // _allCars.Add(Car3);
      // _allCars.Add(Car4);
    }
  
  }
}
