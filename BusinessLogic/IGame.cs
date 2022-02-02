using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesLadders.BusinessLogic
{
    public interface IGame
    {
        IBoard Board { get; }
        IPlayer[] Players { get; }

        // Tuple: Path to next position (for animating it nicely) and win flag.
        Tuple<IEnumerable<int>, bool> Move(int playerIndex);
    }
}
