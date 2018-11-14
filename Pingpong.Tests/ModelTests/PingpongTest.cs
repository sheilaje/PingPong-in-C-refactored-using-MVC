using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Pingpong.Tests
{
  [TestClass]
  public class PingpongTest
  {
    [TestMethod]
        public void PingpongCheck_NumberDivisibleByThree_True()
        {
          Pingpong testPingPong = new Pingpong();
          Assert.AreEqual(true, testPingPong.PingpongCheck(3));
        }
    [TestMethod]
        public void PingpongCheck_NumberDivisibleByFive_True()
        {
          Pingpong testPingPong = new Pingpong();
          Assert.AreEqual(true, testPingPong.PingpongCheck(5));
        }
    [TestMethod]
        public void PingpongCheck_NumberDivisibleByFifteen_True()
        {
          Pingpong testPingPong = new Pingpong();
          Assert.AreEqual(true, testPingPong.PingpongCheck(15));
        }
  }
}
