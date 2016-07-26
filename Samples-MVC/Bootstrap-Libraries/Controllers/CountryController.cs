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
            countryList.Add(new CountryModel { x = 95, y = 95, z = 13.8, name = "BE", country = "Belgium" });
            countryList.Add(new CountryModel { x = 86.5, y = 102.9, z = 14.7, name = "DE", country = "Germany" });
            countryList.Add(new CountryModel { x = 80.8, y = 91.5, z = 15.8, name = "FI", country = "Finland" });
            countryList.Add(new CountryModel { x = 80.4, y = 102.5, z = 12, name = "NL", country = "Netherlands" });
            countryList.Add(new CountryModel { x = 80.3, y = 86.1, z = 11.8, name = "SE", country = "Sweden" });
            countryList.Add(new CountryModel { x = 78.4, y = 70.1, z = 16.6, name = "ES", country = "Spain" });
            countryList.Add(new CountryModel { x = 74.2, y = 68.5, z = 14.5, name = "FR", country = "France" });
            countryList.Add(new CountryModel { x = 73.5, y = 83.1, z = 10, name = "NO", country = "Norway" });
            countryList.Add(new CountryModel { x = 71, y = 93.2, z = 24.7, name = "UK", country = "United Kingdom" });
            countryList.Add(new CountryModel { x = 69.2, y = 57.6, z = 10.4, name = "IT", country = "Italy" });
            countryList.Add(new CountryModel { x = 68.6, y = 20, z = 16, name = "RU", country = "Russia" });
            countryList.Add(new CountryModel { x = 65.5, y = 126.4, z = 35.3, name = "US", country = "United States" });
            countryList.Add(new CountryModel { x = 65.4, y = 50.8, z = 28.5, name = "HU", country = "Hungary" });
            countryList.Add(new CountryModel { x = 63.4, y = 51.8, z = 15.4, name = "PT", country = "Portugal" });
            countryList.Add(new CountryModel { x = 64, y = 82.9, z = 31.3, name = "NZ", country = "New Zealand" });
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