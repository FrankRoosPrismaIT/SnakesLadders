using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SnakesLadders.BusinessLogic.v1
{
    public class GameFactory : IGameFactory
    {
        public IGame CreateGame(IBoardFactory boardFactory, ISquareFactory squareFactory, IPlayerFactory playerFactory, IDiceFactory diceFactory, IDieFactory dieFactory)
        {
            return new Game(boardFactory, squareFactory, playerFactory, diceFactory, dieFactory);
        }
    }
}