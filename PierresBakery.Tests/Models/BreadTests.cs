using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using PierresBakeryBread.Models;

namespace PierresBakeryBread.Tests
{
  [TestClass]
  public class PierresBakeryBreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetPrice_ReturnPrice_String()
    {
      string price = "$5.00";
      Bread newBread = new Bread(price);
      string result = newBread.Price;
      Assert.AreEqual(price, result);
    }
  }
}
