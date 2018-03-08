using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeatherDTOs;

namespace WeatherAPI.Controllers
{
    public class LoginController : ApiController
    {
        private Models.Login model = new Models.Login();

        /// <summary>
        /// GET: Log an user on system with recibed data
        /// </summary>
        /// <param name="user">User data</param>
        /// <returns></returns>
        [Route("weatherapi/login")]
        [HttpGet]
        public IHttpActionResult LoginUser(user user)
        {
            if(user != null && model.validateUser(user))
            {
                //Result: 200 OK
                return Ok();
            }
            //Result: 401 Unauthorized 
            return Unauthorized();
        }

        /// <summary>
        /// POST: Create new user on system
        /// </summary>
        /// <param name="user">User data</param>
        /// <returns></returns>
        [Route("weatherapi/newuser")]
        [HttpPost]
        public IHttpActionResult CreateNewUser(user user)
        {
            if (user != null && model.Newuser(user))
            {
                //Result: 200 OK
                return Ok();
            }
            //409 Conflict
            return Conflict();
        }
    }
}
