using System;
using System.Collections.Generic;
using Models;

namespace Dealership
{
  public class Program
  {
    public static void Main()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, "So stylish and unique!");
      Car yugo = new Car("1980 Yugo Koral", 700, 56000, "Is it French? Is it German?  Is it Japanese?  Who cares?  It runs!";
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "Stately and refined.");
      Car amc = new Car("1976 AMC Pacer", 400, 198000, "A bargain at any price, a steal today!");

      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);
      Console.WriteLine("Enter maximum mileage: ");
      string stringMaxMileage = Console.ReadLine();
      int maxMileage = int.Parse(stringMaxMileage);

      List<Car> CarsMatchingSearch = new List<Car>(0);

      foreach (Car automobile in Cars) { 
        if (automobile.WorthBuying(maxPrice, maxMileage)) 
        {
          CarsMatchingSearch.Add(automobile);
        }
      }
      if (maxPrice < 400) {
        Console.WriteLine ("We're so sorry.  We have no cars in your price range.  Maybe consider a bicycle?");
      } else {
        foreach (Car automobile in CarsMatchingSearch) {
          Console.WriteLine(automobile.GetMakeModel());
      }
    }
  }
}
}