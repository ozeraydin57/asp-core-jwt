using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTCoreApi.Controllers
{
    [Authorize]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpGet]
        [Route("api/[controller]/usersecurelist")]
        public IEnumerable<string> SecureList()
        {
            List<string> list = new List<string>()
            {
                "Özer","Hasan","Kamil"
            };
            return list;
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("api/[controller]/userpubliclist")]
        public IEnumerable<string> PublicList()
        {
            List<string> list = new List<string>()
            {
                "Ayşe","Fatma","Hayriye"
            };
            return list;
        }

    }
}
