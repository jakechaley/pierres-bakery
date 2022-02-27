using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakeryBread.Models;

[TestClass]
public class PierresBakeryPastryTests
{
  [TestMethod]
  public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
  {
    Pastry newPastry = new Pastry(3);
    Assert.AreEqual(typeof(Pastry), newPastry.GetType());
  }

  [TestMethod]
  public void GetPastryInput_ReturnPastryInput_int()
  {
    int userInput = 3;
    Pastry newPastry = new Pastry(userInput);
    int result = newPastry.PastryAmount;
    Assert.AreEqual(userInput, result);
  }

  [TestMethod]
  public void CalculateCost_ReturnCost_int()
  {
    int testPastryAmount = 1;
    int testPrice = 2;
    Pastry newPastry = new Pastry(testPastryAmount);
    int result = newPastry.CalculateCost();
    Assert.AreEqual(testPrice, result);
  }

  [TestMethod]
  public void CalculateCost_ReturnCostWithDeal_int()
  {
    int testPastryAmount = 7;
    int testPrice = 12;
    Pastry newPastry = new Pastry(testPastryAmount);
    int result = newPastry.CalculateCost();
    Assert.AreEqual(testPrice, result);
  }
}

