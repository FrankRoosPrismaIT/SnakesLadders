using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SnakesLadders.BusinessLogic.v1
{
    public class PlayerFactory : IPlayerFactory
    {
        public IPlayer CreatePlayer()
        {
            return new Player();
        }
    }
}