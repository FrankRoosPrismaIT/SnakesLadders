using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesLadders.BusinessLogic
{
    public interface ISquareFactory
    {
        ISquare CreateSquare();
    }
}
