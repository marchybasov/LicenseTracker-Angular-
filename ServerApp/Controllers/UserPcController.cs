using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServerApp.Models_New;
using Microsoft.EntityFrameworkCore;

namespace ServerApp.Controllers
{
    [Route("api/pcs")]
    [ApiController]
    public class UserPcController : Controller
    {
        private LicenseUsageContext context;
        public UserPcController(LicenseUsageContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IEnumerable<UserPcs> GetUserPCs(bool related = false)
        {
            IQueryable<UserPcs> query = context.UserPcs;

            return query;
        }

    }
}
