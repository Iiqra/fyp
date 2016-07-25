using ChartLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bootstrap_Libraries.Controllers
{
    public class PlayerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PlayerChart()
        {
            Players objPlayers = new Players();
            PlayerDAL objPlayerDAL = new PlayerDAL();
            try
            {
                objPlayers.PlayerList = objPlayerDAL.GetPlayerDetails();
                return View("~/Views/Player/PlayerChart.cshtml", objPlayers);
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        var playerRecordList = new List<ChartLibrary.PlayerRecord>();
        var players = response.ToList(); 
        foreach( player in players) 
            { playerRecordList.Add(new ChartLibrary.PlayerRecord{ //assign properties here from whateverproperty in playerrecord=player.property});

    public JsonResult PlayerDashboardList(Int16? playerId)
        {
            Players objPlayers = new Players();
            PlayerDAL objPlayerDAL = new PlayerDAL();
            if (object.Equals(playerId, null))
            {
                playerId = 1;
            }
            try
            {
                var response = objPlayerDAL.GetPlayerRecordByPlayerId(playerId);
                if (!object.Equals(response, null))
                {
                      objPlayers.PlayerRecordList = response.ToList();                }

                    //var playerRecordList = new List<ChartLibrary.PlayerRecord>();
                    //var players = response.ToList();
                    //foreach (p in players)
                    //{
                    //    playerRecordList.Add(new ChartLibrary.PlayerRecord
                    //    { //assign properties here from whateverproperty in playerrecord=player.property});

                    //    }
            catch (Exception ex)
            {
                throw;
            }
            return Json(objPlayers.PlayerRecordList, JsonRequestBehavior.AllowGet);
        }
    }
}