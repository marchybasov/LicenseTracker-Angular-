using System;
using System.Collections.Generic;

namespace ServerApp.Models_New
{
    public partial class ViewerLicenseUsages
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CurrentlyOccupiedLicense { get; set; }
        public int? FeatureFeatureId { get; set; }
        public int? UsageActionUsageActionId { get; set; }
        public int? UserUserId { get; set; }
        public int? UserPcUserPcid { get; set; }

        public virtual Features FeatureFeature { get; set; }
        public virtual UsageActions UsageActionUsageAction { get; set; }
        public virtual UserPcs UserPcUserPc { get; set; }
        public virtual Users UserUser { get; set; }
    }
}
