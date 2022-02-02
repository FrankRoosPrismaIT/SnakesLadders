using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SnakesLadders.BusinessLogic.v1
{
    public class DieFactory : IDieFactory
    {
        public IDie CreateDie()
        {
            return new Die();
        }
    }
}