using Bootstrap_Libraries.Models;
using Project.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Bootstrap_Libraries.Controllers
{
    public class CountryController : ApiController
    {
        private IBattingRecordsService battingRecordsService;
        public CountryController()
        {

        }
        public CountryController(IBattingRecordsService battingRecordsService)
        {
            this.battingRecordsService = battingRecordsService;
        }
        [HttpGet]
        public IHttpActionResult GetCountries()
        {
            List<CountryModel> countryList = new List<CountryModel>();
            // DAL - get, post, delete, get data through get method and fill here in this controlellr 
            countryList.Add(new CountryModel { run = 204, y = 107, z = 58, country = "IND", countryName = "India", playerName = "Dhoni. M S*" });
            countryList.Add(new CountryModel { run = 294, y = 49, z = 106, country = "LK", countryName = "Sri Lanka", playerName = "Dilshan, TM*" });
            countryList.Add(new CountryModel { run = 232, y = 58, z = 92, country = "IND", countryName = "India", playerName = "Gambhir, G*" });
            countryList.Add(new CountryModel { run = 140, y = 46.7, z = 107, country = "IND", countryName = "India", playerName = "Kohli, V*" });
            countryList.Add(new CountryModel { run = 160, y = 32, z = 83, country = "AUS", countryName = "Australia", playerName = "Marsh, S E*" });
            countryList.Add(new CountryModel { run = 149, y = 76, z = 49.7, country = "PAk", countryName = "Pakistan", playerName = "Misbah-ul-Haq*" });
            countryList.Add(new CountryModel { run = 120, y = 17.1, z = 40, country = "PAK", countryName = "Pakistan", playerName = "Shaid Afridi" });
            countryList.Add(new CountryModel { run = 141, y = 47, z = 76, country = "NZ", countryName = "New Zealand", playerName = "Taylor, L R*" });
            countryList.Add(new CountryModel { run = 132, y = 132, z = 102, country = "SL", countryName = "Sri Lanka", playerName = "Thirimanne, H D R*" });
            countryList.Add(new CountryModel { run = 100,   y = 38.2, z = 191, country = "Aus", countryName = "Australia", playerName = "Warner, D A**" });

            return Json(countryList);



        }

        [HttpGet]
        public IHttpActionResult Action(int test = 1)
        {
            this.battingRecordsService = new BattingRecordsService();
            return Json(this.battingRecordsService.GetAllBattingRecords());
        }




    }

}