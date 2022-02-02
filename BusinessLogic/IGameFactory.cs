using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesLadders.BusinessLogic
{
    public interface IGameFactory
    {
        IGame CreateGame(IBoardFactory boardFactory, ISquareFactory squareFactory, IPlayerFactory playerFactory, IDiceFactory diceFactory, IDieFactory dieFactory);
    }
}
