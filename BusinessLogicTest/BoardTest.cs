using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakesLadders.BusinessLogic.v1;

namespace BusinessLogicTest
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void MoveFreeTest()
        {
            var player = new Player();
            var board = new Board(new SquareFactory());
            player.Position = board.Squares[0];
            var move = board.Move(player, new Dice(new Mock.DieFactory(new[] { 1, 1 })));
            Assert.AreEqual(2, move.Item1);
            Assert.AreEqual(2, move.Item2);
        }
        [TestMethod]
        public void MoveLadderTest()
        {
            var player = new Player();
            var board = new Board(new SquareFactory());
            player.Position = board.Squares[0];
            var move = board.Move(player, new Dice(new Mock.DieFactory(new[] { 4, 2 })));
            Assert.AreEqual(6, move.Item1);
            Assert.AreEqual(13, move.Item2);
        }
        [TestMethod]
        public void MoveSnakeTest()
        {
            var player = new Player();
            var board = new Board(new SquareFactory());
            player.Position = board.Squares[12];
            var move = board.Move(player, new Dice(new Mock.DieFactory(new[] { 1, 2 })));
            Assert.AreEqual(15, move.Item1);
            Assert.AreEqual(5, move.Item2);
        }
        [TestMethod]
        public void MoveWinTest()
        {
            var player = new Player();
            var board = new Board(new SquareFactory());
            player.Position = board.Squares[96];
            var move = board.Move(player, new Dice(new Mock.DieFactory(new[] { 1, 2 })));
            Assert.IsTrue(move.Item3);
        }
        [TestMethod]
        public void MoveNotWinTest()
        {
            var player = new Player();
            var board = new Board(new SquareFactory());
            player.Position = board.Squares[90];
            var move = board.Move(player, new Dice(new Mock.DieFactory(new[] { 1, 2 })));
            Assert.IsFalse(move.Item3);
        }
        [TestMethod]
        public void MoveBounceTest()
        {
            var player = new Player();
            var board = new Board(new SquareFactory());
            player.Position = board.Squares[96];
            var move = board.Move(player, new Dice(new Mock.DieFactory(new[] { 4, 3 })));
            Assert.AreEqual(95, move.Item1);
            Assert.AreEqual(95, move.Item2);
        }
    }
}
