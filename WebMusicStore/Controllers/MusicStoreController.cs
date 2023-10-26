using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMusicStore.Controllers
{
    public class MusicStoreController : Controller
    {
        // GET: MusicStore
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Pop()
        {
            return View();
        }

        public ActionResult Urbano()
        {
            return View();
        }

        public ActionResult ClassicRap()
        {
            return View();
        }
    }
}