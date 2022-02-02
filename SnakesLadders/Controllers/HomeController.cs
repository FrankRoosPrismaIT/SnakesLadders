using SnakesLadders.BusinessLogic;
using SnakesLadders.BusinessLogic.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SnakesLadders.Controllers
{
    public class HomeController : Controller
    {
        private static Dictionary<string, IGame> _game = new Dictionary<string, IGame>();
        protected IGame Game
        {
            get
            {
                if (!_game.ContainsKey(Session.SessionID))
                {
                    _game.Add(Session.SessionID, new GameFactory().CreateGame(new BoardFactory(), new SquareFactory(), new PlayerFactory(), new DiceFactory(), new DieFactory()));
                }
                return _game[Session.SessionID];
            }
        }

        public ActionResult Index()
        {
            Session["aap"] = "noot";
            if (_game.ContainsKey(Session.SessionID))
            {
                _game.Remove(Session.SessionID);
            }
            return View();
        }

        public ActionResult Move(int id)
        {
            var move = Game.Move(id);
            return Json(move, JsonRequestBehavior.AllowGet);
        }
    }
}