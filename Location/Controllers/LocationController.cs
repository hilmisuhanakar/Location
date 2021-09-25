using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Location.Bussines;

namespace Location.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        LocationBussines data = new LocationBussines();

        /// <summary>
        /// Ülkeler json formatında listelendi
        /// </summary>
        /// <returns></returns>

        [Route("country")]
        [HttpGet]
        public string GetCountry()
        {
            return (new JavaScriptSerializer().Serialize(data.ListCountry()));
        }

        /// <summary>
        /// Şehirler json formatında listelendi
        /// </summary>
        /// <param name="countryId"></param>
        /// <returns></returns>

        [Route("city/{countryId}")]
        [HttpGet]
        public string GetCity(int countryId)
        {
            return (new JavaScriptSerializer().Serialize(data.ListCity(countryId)));
        }
    }
}
