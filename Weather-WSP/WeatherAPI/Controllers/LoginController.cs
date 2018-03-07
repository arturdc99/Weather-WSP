using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeatherDTOs.User;

namespace WeatherAPI.Controllers
{
    public class LoginController : ApiController
    {
        /// <summary>
        /// Log an user on system with recibed data
        /// </summary>
        /// <param name="user">User data</param>
        /// <returns></returns>
        [Route("weatherapi/login")]
        [HttpGet]
        public IHttpActionResult LoginUser(LoginUser user)
        {
            if(user != null)
            {
                //Result: 200 OK
                return Ok();
            }
            //Result: 401 Unauthorized 
            return Unauthorized();
        }

        /// <summary>
        /// Create new user on system
        /// </summary>
        /// <param name="user">User data</param>
        /// <returns></returns>
        [Route("weatherapi/newuser")]
        [HttpGet]
        public IHttpActionResult CreateNewUser(LoginUser user)
        {
            if (user != null)
            {
                //Result: 200 OK
                return Ok();
            }
            //409 Conflict
            return Conflict();
        }


    }
}
