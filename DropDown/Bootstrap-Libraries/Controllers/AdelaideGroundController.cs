using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Bootstrap_Libraries.Controllers
{
    public class AdelaideGroundController : ApiController
    {

        [System.Web.Http.HttpGet]
        public IHttpActionResult GetTopBowlers()
        {
            List<TopBowlers> CountryList = new List<TopBowlers>();
            // DAL - get, post, delete, get data through get method and fill here in this controlellr 
            CountryList.Add(new TopBowlers { x = 292, y = 17, z = 17.18, CountryInits = "AUS", CountryName = "Australia", Name = "McKay, C J*" });
            CountryList.Add(new TopBowlers { x = 289, y = 12, z = 24.08, CountryInits = "AUS", CountryName = "Australia", Name = "Hogg, G B*" });
            CountryList.Add(new TopBowlers { x = 231, y = 10, z = 23.1, CountryInits = "SL", CountryName = "Sri Lanka", Name = "Malinga, S L*" });
            CountryList.Add(new TopBowlers { x = 215, y = 9, z = 23.89, CountryInits = "ENG", CountryName = "England", Name = "Anderson, J M*" });
            CountryList.Add(new TopBowlers { x = 274, y = 8, z = 34.25, CountryInits = "SL", CountryName = "Sri Lanka", Name = "Kulasekara, K M D*" });
            CountryList.Add(new TopBowlers { x = 156, y = 8, z = 19.5, CountryInits = "PAk", CountryName = "Pakistan", Name = "Sohail Khan*" });
            CountryList.Add(new TopBowlers { x = 157, y = 6, z = 26.17, CountryInits = "PAK", CountryName = "Pakistan", Name = "Wahab Riaz*" });
            CountryList.Add(new TopBowlers { x = 349, y = 5, z = 69.8, CountryInits = "PAK", CountryName = "Pakistan", Name = "Shahid Afridi*" });
            CountryList.Add(new TopBowlers { x = 104, y = 5, z = 20.8, CountryInits = "IND", CountryName = "India", Name = "Vinay Kumar, R*" });
            CountryList.Add(new TopBowlers { x = 150, y = 4, z = 37.5, CountryInits = "IND", CountryName = "India", Name = "Yadav, U T*" });

            return Json(CountryList);



        }


    }
}