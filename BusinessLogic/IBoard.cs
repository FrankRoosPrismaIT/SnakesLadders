using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesLadders.BusinessLogic
{
    public interface IBoard
    {
        ISquare[] Squares { get; }
        Tuple<int, int, bool> Move(IPlayer player, IDice dice);
    }
}
