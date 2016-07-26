using Bootstrap_Libraries.Models;
using Project.DataLayer;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bootstrap_Libraries.Controllers
{
    public class AdelaideController : Controller
    {
        // GET: Adelaide
        public ActionResult Data()
        {


            //TopBatsman model = new TopBatsman();
            // dbconnection db = new dbconnection();
            return View();
           
            }
            

        public ActionResult Top10NBatsman()
        {
            return View();
        }
        public ActionResult Top10NBowlers()
        {
            return View();
        }


        public ActionResult TeamBattingWise()
        {
            return View();
        }
        public ActionResult TeamBowlingWise()
        {
            return View();
        }


    }
}