using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SnakesLadders.BusinessLogic.v1
{
    public class Die : IDie
    {
        private static Random _random = new Random();

        public Die()
        {
            Value = _random.Next(6) + 1;
        }

        public int Value { get; private set; }
    }
}