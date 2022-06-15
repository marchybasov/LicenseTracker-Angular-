using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServerApp.Models_New;

namespace ServerApp.Controllers
{
    [Route ("api/users")]
    [ApiController]
    public class UsersController : Controller
    {
        private LicenseUsageContext context;
        public UsersController(LicenseUsageContext ctx)
        {
            context = ctx;
        }
       
        [HttpGet ("{id}")]
        public Users GetUser(int id)
        {
           
            return context.Users.Find(id);
        }

        [HttpGet]
        public IEnumerable<Users> GetUserPCs(bool related = false)
        {
            IQueryable<Users> query = context.Users;

            return query;
        }


    }
}
