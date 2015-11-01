using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using BookLibrary.BL;


namespace BookLibrary
{
    public class UserController : ApiController
    {

        [Route("api/User/AddUser")]
        [HttpPost]
        public IHttpActionResult PostUserDTO(UserDTO userDTO)
        {
            UserProvider.AddUser(userDTO);

            return Ok(userDTO);
        }

        [Route("api/User/GetCitiesByPrifix/{Prefix}")]
        [HttpGet]
        public IHttpActionResult GetCitiesByPrifix(string Prefix)
        {
            return Ok(CityProvider.GetCitiesByPrifix(Prefix));
        }

        [Route("api/User/GetCities")]
        [HttpGet]
        public IHttpActionResult GetCities()
        {
            return Ok(CityProvider.GetCities());
        }

    }
}