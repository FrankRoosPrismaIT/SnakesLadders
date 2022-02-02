using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SnakesLadders.BusinessLogic.v1
{
    public class Board : IBoard
    {
        public Board(ISquareFactory squareFactory)
        {
            for (int i = 99; i > -1; i--)
            {
                Squares[i] = squareFactory.CreateSquare();
            }

            // Ladders
            Squares[1].EndPoint = Squares[37];
            Squares[6].EndPoint = Squares[13];
            Squares[7].EndPoint = Squares[30];
            Squares[14].EndPoint = Squares[25];
            Squares[20].EndPoint = Squares[41];
            Squares[27].EndPoint = Squares[83];
            Squares[35].EndPoint = Squares[43];
            Squares[50].EndPoint = Squares[66];
            Squares[70].EndPoint = Squares[90];
            Squares[77].EndPoint = Squares[97];
            Squares[86].EndPoint = Squares[93];

            // Snakes
            Squares[15].EndPoint = Squares[5];
            Squares[45].EndPoint = Squares[24];
            Squares[48].EndPoint = Squares[10];
            Squares[61].EndPoint = Squares[18];
            Squares[63].EndPoint = Squares[59];
            Squares[73].EndPoint = Squares[52];
            Squares[88].EndPoint = Squares[67];
            Squares[91].EndPoint = Squares[87];
            Squares[94].EndPoint = Squares[74];
            Squares[98].EndPoint = Squares[79];
        }

        private ISquare[] _squares = new ISquare[100];
        public ISquare[] Squares => _squares;

        public Tuple<int, int, bool> Move(IPlayer player, IDice dice)
        {
            var currentIndex = Array.IndexOf(Squares, player.Position);
            var newIndex = currentIndex + dice.Value;

            // 'Bounce' off the end.
            if (newIndex > 99)
            {
                newIndex = 99 - (newIndex - 99);
            }

            player.Position = Squares[newIndex].EndPoint ?? Squares[newIndex];
            var endPoint = Array.IndexOf(Squares, player.Position);

            return new Tuple<int, int, bool>(newIndex, endPoint, endPoint == 99);
        }
    }
}