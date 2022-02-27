using System;

namespace PierresBakeryPastry.Models
{
  public class Pastry
  {
    public int PastryAmount { get; set; }
    public int PriceFor1Pastry { get; }
    public int PriceFor3Pastry { get; }
    public Pastry(int pastryAmount)
    {
      PastryAmount = pastryAmount;
      PriceFor1Pastry = 2;
      PriceFor3Pastry = 5;
    }

    public int CalculateCost()
    {
      decimal bundleAmount = Decimal.Floor(PastryAmount / 3);
      int intBundleAmount = Decimal.ToInt32(bundleAmount);
      int remainderPastry = PastryAmount % 3; 
      return (intBundleAmount * PriceFor3Pastry) + (remainderPastry * PriceFor1Pastry);
    }
  }
}

