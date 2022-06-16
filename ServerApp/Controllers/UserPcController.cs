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

        [HttpGet("{category}")]
        public IEnumerable<UserPcs> GetUsersPerCategory(string category)
        {
            IEnumerable<UserPcs> res = new List<UserPcs>();
            switch (category.ToLower())
            {
                case "solidworks":
                    res = context.SolidworksLicenseUsages.Where(p => p.FeatureFeatureId == 1).Select(p => p.UserPcUserPc).Distinct();
                    break;
                case "pdm":
                    res = context.SolidworksLicenseUsages.Where(p => p.FeatureFeatureId == 2).Select(p => p.UserPcUserPc).Distinct();
                    break;
                case "viewer":
                    res = context.SolidworksLicenseUsages.Where(p => p.FeatureFeatureId == 4).Select(p => p.UserPcUserPc).Distinct();
                    break;
            }


            return res.OrderBy(p => p.Pcname);

        }

    }
}
