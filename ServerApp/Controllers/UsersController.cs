using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServerApp.Models_New;
using Microsoft.EntityFrameworkCore;

namespace ServerApp.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : Controller
    {
        private LicenseUsageContext context;
        public UsersController(LicenseUsageContext ctx)
        {
            context = ctx;
        }

     
        [HttpGet]
        public IEnumerable<Users> GetUsers(bool related = false)
        {
            IQueryable<Users> query = context.Users;

            return query.OrderBy(p=>p.FullName);
        }

        [HttpGet("{category}")]
        public IEnumerable<Users> GetUsersPerCategory(string category)
        {
            IEnumerable<Users> res = new List<Users>();
            switch (category.ToLower())
            {
                case "solidworks":
                    res = context.SolidworksLicenseUsages.Where(p=>p.FeatureFeatureId==1).Select(p => p.UserUser).Distinct();                   
                    break;
                case "pdm":
                    res = context.SolidworksLicenseUsages.Where(p=>p.FeatureFeatureId==2).Select(p => p.UserUser).Distinct();
                    break;
                case "viewer":
                    res = context.SolidworksLicenseUsages.Where(p=>p.FeatureFeatureId==4).Select(p => p.UserUser).Distinct();
                    break;
            }
            
           
            return res.OrderBy(p=>p.FullName);

        }


    }
}
