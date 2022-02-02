using SnakesLadders.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTest.Mock
{
    public class Die : IDie
    {
        public Die(int value)
        {
            Value = value;
        }

        public int Value { get; private set; }
    }
}
