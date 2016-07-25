using Bootstrap_Libraries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bootstrap_Libraries.Controllers
{
  public class HomeController : Controller
  {

        PlayerDb _db = new PlayerDb();
        public ActionResult Index()
    {
            return View(RSSReader.GetRssFeed());
           
        }
        public ActionResult Stats()
        {
            return View();
        }
        public ActionResult Analysis ()
        {
            return View();
        }
        public ActionResult LogIn()
        {
            return View();
        }
        public ActionResult PlyaersList()
        {

            //var model = _db.Players.ToList();
            return View();
        }





        //  public ActionResult RssReader()
        //{
        //   return View(RSSReader.GetRssFeed());
        //}




    }
}