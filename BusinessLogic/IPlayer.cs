using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesLadders.BusinessLogic
{
    public interface IPlayer
    {
        ISquare Position { get; set; }
    }
}
