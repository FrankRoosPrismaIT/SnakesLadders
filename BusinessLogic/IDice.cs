using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesLadders.BusinessLogic
{
    public interface IDice
    {
        Tuple<IDie, IDie> Values { get; }
        int Value { get; }
        bool Again { get; }
    }
}
