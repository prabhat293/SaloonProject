using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UserApi.Controllers
{
    public class UserController : ApiController
    {
        [HttpPost]
        [Route("Users")]
        public string RegisterUser()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("Login")]
        public string Login()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("User")]
        public string CheckUser()
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("Password")]
        public string ResetPassword()
        {
            throw new NotImplementedException();
        }
    }
}
