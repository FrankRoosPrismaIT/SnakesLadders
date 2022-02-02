using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SnakesLadders.BusinessLogic.v1
{
    public class DiceFactory : IDiceFactory
    {
        public IDice CreateDice(IDieFactory dieFactory)
        {
            return new Dice(dieFactory);
        }
    }
}