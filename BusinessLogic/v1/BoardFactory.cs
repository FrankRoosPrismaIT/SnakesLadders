using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SnakesLadders.BusinessLogic.v1
{
    public class BoardFactory : IBoardFactory
    {
        public IBoard CreateBoard(ISquareFactory squareFactory)
        {
            return new Board(squareFactory);
        }
    }
}