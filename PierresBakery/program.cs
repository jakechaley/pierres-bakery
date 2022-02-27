using System;
using System.Collections.Generic;
using PierresBakeryBread.Models;
using PierresBakeryPastry.Models;


namespace CommandLineInterface
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery! We specialize in making the best bread and pastries in town! Here's our  menu. Our loaves of bread are $5.00 each but if you buy 2 you get the 3rd loaf for free! Our pastries are $2.00 for 1 pastry or $5.00 for a bundle of 3 pastries!");
      Console.WriteLine("Press ENTER to start your order.");
      Console.ReadKey();
      NewOrder();
    }
    private static void NewOrder()
    {
      Console.WriteLine("How many loaves of bread would you like?");
      string userInputBread = Console.ReadLine();
      int loavesOfBread = Int32.Parse(userInputBread);
      Console.WriteLine("How many pastries would you like?");
      string userInputPastry = Console.ReadLine();
      int numberOfPastry = Int32.Parse(userInputPastry);
      Bread newBread = new Bread(loavesOfBread);
      int calculatedBreadCost = newBread.CalculateCost();
      Pastry newPastry = new Pastry(numberOfPastry);
      int calculatedPastryCost = newPastry.CalculateCost();
      Console.WriteLine("You're order total is $" + (calculatedBreadCost + calculatedPastryCost));
      // Console.WriteLine("You're order total is $"+(loavesOfBread + numberOfPastry));
    }
  }
}