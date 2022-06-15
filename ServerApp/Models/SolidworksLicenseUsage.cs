using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Models
{
    public class SolidworksLicenseUsage
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public Feature Feature { get; set; }

        public UsageAction UsageAction { get; set; }

        public User User { get; set; }

        public UserPC UserPC { get; set; }

        public int CurrentlyOccupiedLicense { get; set; }
    }
}
