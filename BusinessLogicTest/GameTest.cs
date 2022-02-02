using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakesLadders.BusinessLogic.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTest
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void MoveFreeTest()
        {
            var game = new Game(new BoardFactory(), new SquareFactory(), new PlayerFactory(), new DiceFactory() , new Mock.DieFactory(new[] { 1, 2 }));
            var move = game.Move(0);
            Assert.AreEqual(2, move.Item1.Count());
            Assert.AreEqual(0, move.Item1.First());
            Assert.AreEqual(3, move.Item1.Last());
        }
        [TestMethod]
        public void MoveLadderTest()
        {
            var game = new Game(new BoardFactory(), new SquareFactory(), new PlayerFactory(), new DiceFactory(), new Mock.DieFactory(new[] { 4, 2 }));
            var move = game.Move(0);
            Assert.AreEqual(3, move.Item1.Count());
            Assert.AreEqual(0, move.Item1.First());
            Assert.AreEqual(13, move.Item1.Last());
        }
        [TestMethod]
        public void MoveDoubleTest()
        {
            var game = new Game(new BoardFactory(), new SquareFactory(), new PlayerFactory(), new DiceFactory(), new Mock.DieFactory(new[] { 1, 1, 2, 4 }));
            var move = game.Move(0);
            Assert.AreEqual(3, move.Item1.Count());
            Assert.AreEqual(0, move.Item1.First());
            Assert.AreEqual(8, move.Item1.Last());
            Assert.IsFalse(move.Item2);
        }
        [TestMethod]
        public void MoveWinDoubleTest()
        {
            var game = new Game(new BoardFactory(), new SquareFactory(), new PlayerFactory(), new DiceFactory(), new Mock.DieFactory(new[] { 2, 2 }));
            game.Players[0].Position = game.Board.Squares[95];
            var move = game.Move(0);
            Assert.AreEqual(2, move.Item1.Count());
            Assert.AreEqual(99, move.Item1.Last());
            Assert.IsTrue(move.Item2);
        }
    }
}
