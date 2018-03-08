using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeatherDTOs;

namespace WeatherAPI.Controllers
{
    public class WeatherDataController : ApiController
    {
        public IHttpActionResult saveLog(history_search newEntry)
        {
            if(newEntry != null)
            {
                //Result: 200 OK
                return Ok();
            }
            //409 Conflict
            return Conflict();
        }


    }
}
