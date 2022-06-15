﻿using System;
using System.Collections.Generic;

namespace ServerApp.Models_New
{
    public partial class Users
    {
        public Users()
        {
            OtherLicenseUsages = new HashSet<OtherLicenseUsages>();
            PdmlicenseUsages = new HashSet<PdmlicenseUsages>();
            SolidworksLicenseUsages = new HashSet<SolidworksLicenseUsages>();
            ViewerLicenseUsages = new HashSet<ViewerLicenseUsages>();
        }

        public int UserId { get; set; }
        public string FullName { get; set; }

        public virtual ICollection<OtherLicenseUsages> OtherLicenseUsages { get; set; }
        public virtual ICollection<PdmlicenseUsages> PdmlicenseUsages { get; set; }
        public virtual ICollection<SolidworksLicenseUsages> SolidworksLicenseUsages { get; set; }
        public virtual ICollection<ViewerLicenseUsages> ViewerLicenseUsages { get; set; }
    }
}
