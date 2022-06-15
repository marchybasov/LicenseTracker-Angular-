using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ServerApp.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts) : base(opts)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<UsageAction> UsageActions { get; set; }
        public DbSet<UserPC> UserPCs { get; set; }
        public DbSet<SolidworksLicenseUsage> SolidworksLicenseUsages { get; set; }
    }
}
