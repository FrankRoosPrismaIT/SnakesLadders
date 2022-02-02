using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SnakesLadders.BusinessLogic.v1
{
    public class Dice : IDice
    {
        public Dice(IDieFactory dieFactory)
        {
            Values = new Tuple<IDie, IDie>(dieFactory.CreateDie(), dieFactory.CreateDie());
        }

        public Tuple<IDie, IDie> Values { get; private set; }

        public int Value => Values.Item1.Value + Values.Item2.Value;

        // Double -> Roll again.
        public bool Again => Values.Item1.Value == Values.Item2.Value;
    }
}