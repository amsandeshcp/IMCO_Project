using IMCO.Models.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IMCO.Services.Controllers.UserAccount
{
    [RoutePrefix("api/user-verify")]
    public class UserAccountController : ApiController
    {
        [HttpPost, HttpGet]
        [Route("validate-login")]
        public IHttpActionResult ValidateLogin([FromBody]ClsLoginRequest request)
        {
            // var response = new UserAccountDetailsBAL().ValidateLoginCredential(request);
            var response = false;
            
            if (request.Model.UserName == "sam" && request.Model.Password == "sam123")
            { response = true; }
            return Ok(response);
        }

        [HttpGet]
        [Route("validate-login")]
        public IHttpActionResult ValidateLogin(string Uname, string Pass)
        {
            var response = false;
            if (Uname == "sam" && Pass == "sam123")
            { response = true; }
            
            return Ok(response);
        }
    }
}
