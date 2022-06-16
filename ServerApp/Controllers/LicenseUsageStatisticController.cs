using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServerApp.Models_New;
using Microsoft.EntityFrameworkCore;


namespace ServerApp.Controllers
{
    [Route("api/statistic")]
    [ApiController]
    public class LicenseUsageStatisticController : Controller
    {
        private LicenseUsageContext context;
        public LicenseUsageStatisticController(LicenseUsageContext ctx)
        {
            context = ctx;
        }
        [HttpGet]
        public LicenseUsage_Avg GetStatisticData()
        {
            return new LicenseUsage_Avg
            {
                AvgUsage7_8 = (int)context.SolidworksLicenseUsages.Where(x => (x.CreatedAt.Hour >= 7 && x.CreatedAt.Hour < 8)).Select(x => x.CurrentlyOccupiedLicense).Average(),
                AvgUsage8_9 = (int)context.SolidworksLicenseUsages.Where(x => (x.CreatedAt.Hour >= 8 && x.CreatedAt.Hour < 9)).Select(x => x.CurrentlyOccupiedLicense).Average(),
                AvgUsage9_10 = (int)context.SolidworksLicenseUsages.Where(x => (x.CreatedAt.Hour >= 9 && x.CreatedAt.Hour < 10)).Select(x => x.CurrentlyOccupiedLicense).Average(),
                AvgUsage10_11 = (int)context.SolidworksLicenseUsages.Where(x => x.CreatedAt.Hour >= 10 && x.CreatedAt.Hour < 11).Select(x => x.CurrentlyOccupiedLicense).Average(),
                AvgUsage11_12 = (int)context.SolidworksLicenseUsages.Where(x => x.CreatedAt.Hour >= 11 && x.CreatedAt.Hour < 12).Select(x => x.CurrentlyOccupiedLicense).Average(),
                AvgUsage12_13 = (int)context.SolidworksLicenseUsages.Where(x => x.CreatedAt.Hour >= 12 && x.CreatedAt.Hour < 13).Select(x => x.CurrentlyOccupiedLicense).Average(),
                AvgUsage13_14 = (int)context.SolidworksLicenseUsages.Where(x => x.CreatedAt.Hour >= 13 && x.CreatedAt.Hour < 14).Select(x => x.CurrentlyOccupiedLicense).Average(),
                AvgUsage14_15 = (int)context.SolidworksLicenseUsages.Where(x => x.CreatedAt.Hour >= 14 && x.CreatedAt.Hour < 15).Select(x => x.CurrentlyOccupiedLicense).Average(),
                AvgUsage15_16 = (int)context.SolidworksLicenseUsages.Where(x => x.CreatedAt.Hour >= 15 && x.CreatedAt.Hour < 16).Select(x => x.CurrentlyOccupiedLicense).Average(),
                AvgUsage16_17 = (int)context.SolidworksLicenseUsages.Where(x => x.CreatedAt.Hour >= 16 && x.CreatedAt.Hour < 17).Select(x => x.CurrentlyOccupiedLicense).Average(),
                AvgUsage17_18 = (int)context.SolidworksLicenseUsages.Where(x => x.CreatedAt.Hour >= 17 && x.CreatedAt.Hour < 18).Select(x => x.CurrentlyOccupiedLicense).Average(),
                AvgUsage18_19 = (int)context.SolidworksLicenseUsages.Where(x => x.CreatedAt.Hour >= 18 && x.CreatedAt.Hour < 19).Select(x => x.CurrentlyOccupiedLicense).Average(),
            LicenseAmount =44
            };
        }

        [HttpGet("{category}")]
        public LicenseUsage_Avg GetStatisticPerCategory(string category)
        {
            int categoryId = 0;
            int license = 39;
            switch (category)
            {
                case "solidworks":
                    categoryId = 1;
                    break;
                case "pdm":
                    categoryId = 2;
                    break;
                case "viewer":
                    categoryId = 4;
                    license = 5;
                    break;
                default:
                    break;
            }

            return new LicenseUsage_Avg
            {
                AvgUsage7_8 = (int)context.SolidworksLicenseUsages.Where(x => (x.CreatedAt.Hour >= 7 && x.CreatedAt.Hour < 8 && x.FeatureFeature.FeatureId == categoryId)).Select(x => x.CurrentlyOccupiedLicense).Average(),
                AvgUsage8_9 = (int)context.SolidworksLicenseUsages.Where(x => (x.CreatedAt.Hour >= 8 && x.CreatedAt.Hour < 9 && x.FeatureFeature.FeatureId == categoryId)).Select(x => x.CurrentlyOccupiedLicense).Average(),
                AvgUsage9_10 = (int)context.SolidworksLicenseUsages.Where(x => (x.CreatedAt.Hour >= 9 && x.CreatedAt.Hour < 10) && x.FeatureFeature.FeatureId == categoryId).Select(x => x.CurrentlyOccupiedLicense).Average(),
                AvgUsage10_11 = (int)context.SolidworksLicenseUsages.Where(x => x.CreatedAt.Hour >= 10 && x.CreatedAt.Hour < 11 && x.FeatureFeature.FeatureId == categoryId).Select(x => x.CurrentlyOccupiedLicense).Average(),
                AvgUsage11_12 = (int)context.SolidworksLicenseUsages.Where(x => x.CreatedAt.Hour >= 11 && x.CreatedAt.Hour < 12 && x.FeatureFeature.FeatureId == categoryId).Select(x => x.CurrentlyOccupiedLicense).Average(),
                AvgUsage12_13 = (int)context.SolidworksLicenseUsages.Where(x => x.CreatedAt.Hour >= 12 && x.CreatedAt.Hour < 13 && x.FeatureFeature.FeatureId == categoryId).Select(x => x.CurrentlyOccupiedLicense).Average(),
                AvgUsage13_14 = (int)context.SolidworksLicenseUsages.Where(x => x.CreatedAt.Hour >= 13 && x.CreatedAt.Hour < 14 && x.FeatureFeature.FeatureId == categoryId).Select(x => x.CurrentlyOccupiedLicense).Average(),
                AvgUsage14_15 = (int)context.SolidworksLicenseUsages.Where(x => x.CreatedAt.Hour >= 14 && x.CreatedAt.Hour < 15 && x.FeatureFeature.FeatureId == categoryId).Select(x => x.CurrentlyOccupiedLicense).Average(),
                AvgUsage15_16 = (int)context.SolidworksLicenseUsages.Where(x => x.CreatedAt.Hour >= 15 && x.CreatedAt.Hour < 16 && x.FeatureFeature.FeatureId == categoryId).Select(x => x.CurrentlyOccupiedLicense).Average(),
                AvgUsage16_17 = (int)context.SolidworksLicenseUsages.Where(x => x.CreatedAt.Hour >= 16 && x.CreatedAt.Hour < 17 && x.FeatureFeature.FeatureId == categoryId).Select(x => x.CurrentlyOccupiedLicense).Average(),
                AvgUsage17_18 = (int)context.SolidworksLicenseUsages.Where(x => x.CreatedAt.Hour >= 17 && x.CreatedAt.Hour < 18 && x.FeatureFeature.FeatureId == categoryId).Select(x => x.CurrentlyOccupiedLicense).Average(),
                AvgUsage18_19 = (int)context.SolidworksLicenseUsages.Where(x => x.CreatedAt.Hour >= 18 && x.CreatedAt.Hour < 19 && x.FeatureFeature.FeatureId == categoryId).Select(x => x.CurrentlyOccupiedLicense).Average(),
                LicenseAmount = license
            };
        }

    }
}
