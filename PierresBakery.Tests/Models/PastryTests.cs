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
}

