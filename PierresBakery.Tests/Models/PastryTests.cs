using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakeryBread.Models;

[TestClass]
public class PierresBakeryPastryTests
{
  [TestMethod]
  public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
  {
    Pastry newPastry = new Pastry();
    Assert.AreEqual(typeof(Pastry), newPastry.GetType());
  }
}