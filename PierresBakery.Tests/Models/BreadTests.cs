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
      Bread newBread = new Bread(5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadInput_ReturnsBreadInput_Int()
    {
      int testBread = 5;
      Bread newBread = new Bread(testBread);
      int result = newBread.UserBread;
      Assert.AreEqual(testBread, result);
    }

    [TestMethod]
    public void CalculateCost_ReturnCost_int()
    {
      int testBread = 2;
      int testCost = 10;
      Bread newBread = new Bread(testBread);
      int result = newBread.CalculateCost();
      Assert.AreEqual(testCost, result);
    }

    [TestMethod]
    public void CalculateCost_ReturnCostWithDeal_int()
    {
      int testBread = 6;
      int testCost = 20;
      Bread newBread = new Bread(testBread);
      int result = newBread.CalculateCost();
      Assert.AreEqual(testCost, result);
    }
  }
}
