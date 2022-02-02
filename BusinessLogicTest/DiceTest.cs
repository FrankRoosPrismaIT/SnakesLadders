using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakesLadders.BusinessLogic.v1;

namespace BusinessLogicTest
{
    [TestClass]
    public class DiceTest
    {
        [TestMethod]
        public void ValueTest()
        {
            var dieFactory = new Mock.DieFactory(new[] { 1, 2 });
            var dice = new Dice(dieFactory);
            Assert.AreEqual(3, dice.Value);
        }

        [TestMethod]
        public void DoubleTest()
        {
            var dieFactory = new Mock.DieFactory(new[] { 1, 1 });
            var dice = new Dice(dieFactory);
            Assert.IsTrue(dice.Again);
        }

        [TestMethod]
        public void NotDoubleTest()
        {
            var dieFactory = new Mock.DieFactory(new[] { 1, 2 });
            var dice = new Dice(dieFactory);
            Assert.IsFalse(dice.Again);
        }
    }
}
