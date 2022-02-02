using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SnakesLadders.BusinessLogic.v1
{
    public class Game : IGame
    {
        private IDiceFactory _diceFactory;
        private IDieFactory _dieFactory;

        public Game(IBoardFactory boardFactory, ISquareFactory squareFactory, IPlayerFactory playerFactory, IDiceFactory diceFactory, IDieFactory dieFactory)
        {
            _diceFactory = diceFactory;
            _dieFactory = dieFactory;
            Board = boardFactory.CreateBoard(squareFactory);
            Players = new IPlayer[4];
            for (int i = 0; i < 4; i++)
            {
                Players[i] = playerFactory.CreatePlayer();
                Players[i].Position = Board.Squares[0];
            }
        }

        public IBoard Board { get; private set; }
        public IPlayer[] Players { get; private set; }

        public Tuple<IEnumerable<int>, bool> Move(int playerIndex)
        {
            var player = Players[playerIndex];
            var result = new List<int>();
            result.Add(Array.IndexOf(Board.Squares, player.Position));
            bool win;
            while (true)
            {
                var dice = _diceFactory.CreateDice(_dieFactory);
                var move = Board.Move(player, dice);
                result.Add(move.Item1);
                win = move.Item3;
                if (move.Item2 != move.Item1)
                {
                    result.Add(move.Item2);
                }
                if (move.Item3 || !dice.Again)
                {
                    break;
                }
            }
            return new Tuple<IEnumerable<int>, bool>(result, win);
        }
    }
}