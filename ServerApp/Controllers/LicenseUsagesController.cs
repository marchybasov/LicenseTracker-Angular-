using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServerApp.Models_New;
using Microsoft.EntityFrameworkCore;

namespace ServerApp.Controllers
{
    [Route("api/licenseusages")]
    [ApiController]
    public class LicenseUsagesController : Controller
    {
        private readonly LicenseUsageContext context;
        public LicenseUsagesController(LicenseUsageContext ctx)
        {
            context = ctx;
        }

        [HttpGet("{id}")]
        public SolidworksLicenseUsages GetLicenseUsages(int id, bool related = false)
        {
            IQueryable<SolidworksLicenseUsages> query = context.SolidworksLicenseUsages;

            SolidworksLicenseUsages res = query.Include(p => p.UserPcUserPc).Include(p=>p.UserUser).Include(p=>p.UsageActionUsageAction).Include(p=>p.FeatureFeature).Where(p => p.Id == id).First();
            if (res!= null)
            {
                if (res.UserPcUserPc != null)
                {
                    res.UserPcUserPc.SolidworksLicenseUsages = null; 
                }
                if (res.UserUser != null)
                {
                    res.UserUser.SolidworksLicenseUsages = null;
                }
                if (res.FeatureFeature != null)
                {
                    res.FeatureFeature.SolidworksLicenseUsages = null;
                }
                if (res.UsageActionUsageAction !=null)
                {
                    res.UsageActionUsageAction.SolidworksLicenseUsages = null;
                }

            }
            return res;           
        }
    }
}
