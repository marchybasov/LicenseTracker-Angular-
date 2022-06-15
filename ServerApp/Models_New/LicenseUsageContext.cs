using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ServerApp.Models_New
{
    public partial class LicenseUsageContext : DbContext
    {
        public LicenseUsageContext()
        {
        }

        public LicenseUsageContext(DbContextOptions<LicenseUsageContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Features> Features { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<OtherLicenseUsages> OtherLicenseUsages { get; set; }
        public virtual DbSet<PdmlicenseUsages> PdmlicenseUsages { get; set; }
        public virtual DbSet<SolidworksLicenseUsages> SolidworksLicenseUsages { get; set; }
        public virtual DbSet<UsageActions> UsageActions { get; set; }
        public virtual DbSet<UserPcs> UserPcs { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<ViewerLicenseUsages> ViewerLicenseUsages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Features>(entity =>
            {
                entity.HasKey(e => e.FeatureId)
                    .HasName("PK_dbo.Features");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<OtherLicenseUsages>(entity =>
            {
                entity.HasIndex(e => e.FeatureFeatureId)
                    .HasName("IX_Feature_FeatureId");

                entity.HasIndex(e => e.UsageActionUsageActionId)
                    .HasName("IX_UsageAction_UsageActionId");

                entity.HasIndex(e => e.UserPcUserPcid)
                    .HasName("IX_UserPC_UserPCId");

                entity.HasIndex(e => e.UserUserId)
                    .HasName("IX_User_UserId");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.FeatureFeatureId).HasColumnName("Feature_FeatureId");

                entity.Property(e => e.UsageActionUsageActionId).HasColumnName("UsageAction_UsageActionId");

                entity.Property(e => e.UserPcUserPcid).HasColumnName("UserPC_UserPCId");

                entity.Property(e => e.UserUserId).HasColumnName("User_UserId");

                entity.HasOne(d => d.FeatureFeature)
                    .WithMany(p => p.OtherLicenseUsages)
                    .HasForeignKey(d => d.FeatureFeatureId)
                    .HasConstraintName("FK_dbo.OtherLicenseUsage_dbo.Feature_Feature_FeatureId");

                entity.HasOne(d => d.UsageActionUsageAction)
                    .WithMany(p => p.OtherLicenseUsages)
                    .HasForeignKey(d => d.UsageActionUsageActionId)
                    .HasConstraintName("FK_dbo.OtherLicenseUsage_dbo.UsageAction_UsageAction_UsageActionId");

                entity.HasOne(d => d.UserPcUserPc)
                    .WithMany(p => p.OtherLicenseUsages)
                    .HasForeignKey(d => d.UserPcUserPcid)
                    .HasConstraintName("FK_dbo.OtherLicenseUsage_dbo.UserPC_UserPC_UserPCId");

                entity.HasOne(d => d.UserUser)
                    .WithMany(p => p.OtherLicenseUsages)
                    .HasForeignKey(d => d.UserUserId)
                    .HasConstraintName("FK_dbo.OtherLicenseUsage_dbo.User_User_UserId");
            });

            modelBuilder.Entity<PdmlicenseUsages>(entity =>
            {
                entity.ToTable("PDMLicenseUsages");

                entity.HasIndex(e => e.FeatureFeatureId)
                    .HasName("IX_Feature_FeatureId");

                entity.HasIndex(e => e.UsageActionUsageActionId)
                    .HasName("IX_UsageAction_UsageActionId");

                entity.HasIndex(e => e.UserPcUserPcid)
                    .HasName("IX_UserPC_UserPCId");

                entity.HasIndex(e => e.UserUserId)
                    .HasName("IX_User_UserId");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.FeatureFeatureId).HasColumnName("Feature_FeatureId");

                entity.Property(e => e.UsageActionUsageActionId).HasColumnName("UsageAction_UsageActionId");

                entity.Property(e => e.UserPcUserPcid).HasColumnName("UserPC_UserPCId");

                entity.Property(e => e.UserUserId).HasColumnName("User_UserId");

                entity.HasOne(d => d.FeatureFeature)
                    .WithMany(p => p.PdmlicenseUsages)
                    .HasForeignKey(d => d.FeatureFeatureId)
                    .HasConstraintName("FK_dbo.PDMLicenseUsage_dbo.Feature_Feature_FeatureId");

                entity.HasOne(d => d.UsageActionUsageAction)
                    .WithMany(p => p.PdmlicenseUsages)
                    .HasForeignKey(d => d.UsageActionUsageActionId)
                    .HasConstraintName("FK_dbo.PDMLicenseUsage_dbo.UsageAction_UsageAction_UsageActionId");

                entity.HasOne(d => d.UserPcUserPc)
                    .WithMany(p => p.PdmlicenseUsages)
                    .HasForeignKey(d => d.UserPcUserPcid)
                    .HasConstraintName("FK_dbo.PDMLicenseUsage_dbo.UserPC_UserPC_UserPCId");

                entity.HasOne(d => d.UserUser)
                    .WithMany(p => p.PdmlicenseUsages)
                    .HasForeignKey(d => d.UserUserId)
                    .HasConstraintName("FK_dbo.PDMLicenseUsage_dbo.User_User_UserId");
            });

            modelBuilder.Entity<SolidworksLicenseUsages>(entity =>
            {
                entity.HasIndex(e => e.FeatureFeatureId)
                    .HasName("IX_Feature_FeatureId");

                entity.HasIndex(e => e.UsageActionUsageActionId)
                    .HasName("IX_UsageAction_UsageActionId");

                entity.HasIndex(e => e.UserPcUserPcid)
                    .HasName("IX_UserPC_UserPCId");

                entity.HasIndex(e => e.UserUserId)
                    .HasName("IX_User_UserId");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.FeatureFeatureId).HasColumnName("Feature_FeatureId");

                entity.Property(e => e.UsageActionUsageActionId).HasColumnName("UsageAction_UsageActionId");

                entity.Property(e => e.UserPcUserPcid).HasColumnName("UserPC_UserPCId");

                entity.Property(e => e.UserUserId).HasColumnName("User_UserId");

                entity.HasOne(d => d.FeatureFeature)
                    .WithMany(p => p.SolidworksLicenseUsages)
                    .HasForeignKey(d => d.FeatureFeatureId)
                    .HasConstraintName("FK_dbo.SolidworksLicenseUsage_dbo.Feature_Feature_FeatureId");

                entity.HasOne(d => d.UsageActionUsageAction)
                    .WithMany(p => p.SolidworksLicenseUsages)
                    .HasForeignKey(d => d.UsageActionUsageActionId)
                    .HasConstraintName("FK_dbo.SolidworksLicenseUsage_dbo.UsageAction_UsageAction_UsageActionId");

                entity.HasOne(d => d.UserPcUserPc)
                    .WithMany(p => p.SolidworksLicenseUsages)
                    .HasForeignKey(d => d.UserPcUserPcid)
                    .HasConstraintName("FK_dbo.SolidworksLicenseUsage_dbo.UserPC_UserPC_UserPCId");

                entity.HasOne(d => d.UserUser)
                    .WithMany(p => p.SolidworksLicenseUsages)
                    .HasForeignKey(d => d.UserUserId)
                    .HasConstraintName("FK_dbo.SolidworksLicenseUsage_dbo.User_User_UserId");
            });

            modelBuilder.Entity<UsageActions>(entity =>
            {
                entity.HasKey(e => e.UsageActionId)
                    .HasName("PK_dbo.UsageActions");
            });

            modelBuilder.Entity<UserPcs>(entity =>
            {
                entity.HasKey(e => e.UserPcid)
                    .HasName("PK_dbo.UserPCs");

                entity.ToTable("UserPCs");

                entity.HasIndex(e => e.Pcname)
                    .HasName("IX_PCName")
                    .IsUnique();

                entity.Property(e => e.UserPcid).HasColumnName("UserPCId");

                entity.Property(e => e.Pcname)
                    .HasColumnName("PCName")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_dbo.Users");
            });

            modelBuilder.Entity<ViewerLicenseUsages>(entity =>
            {
                entity.HasIndex(e => e.FeatureFeatureId)
                    .HasName("IX_Feature_FeatureId");

                entity.HasIndex(e => e.UsageActionUsageActionId)
                    .HasName("IX_UsageAction_UsageActionId");

                entity.HasIndex(e => e.UserPcUserPcid)
                    .HasName("IX_UserPC_UserPCId");

                entity.HasIndex(e => e.UserUserId)
                    .HasName("IX_User_UserId");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.FeatureFeatureId).HasColumnName("Feature_FeatureId");

                entity.Property(e => e.UsageActionUsageActionId).HasColumnName("UsageAction_UsageActionId");

                entity.Property(e => e.UserPcUserPcid).HasColumnName("UserPC_UserPCId");

                entity.Property(e => e.UserUserId).HasColumnName("User_UserId");

                entity.HasOne(d => d.FeatureFeature)
                    .WithMany(p => p.ViewerLicenseUsages)
                    .HasForeignKey(d => d.FeatureFeatureId)
                    .HasConstraintName("FK_dbo.ViewerLicenseUsage_dbo.Feature_Feature_FeatureId");

                entity.HasOne(d => d.UsageActionUsageAction)
                    .WithMany(p => p.ViewerLicenseUsages)
                    .HasForeignKey(d => d.UsageActionUsageActionId)
                    .HasConstraintName("FK_dbo.ViewerLicenseUsage_dbo.UsageAction_UsageAction_UsageActionId");

                entity.HasOne(d => d.UserPcUserPc)
                    .WithMany(p => p.ViewerLicenseUsages)
                    .HasForeignKey(d => d.UserPcUserPcid)
                    .HasConstraintName("FK_dbo.ViewerLicenseUsage_dbo.UserPC_UserPC_UserPCId");

                entity.HasOne(d => d.UserUser)
                    .WithMany(p => p.ViewerLicenseUsages)
                    .HasForeignKey(d => d.UserUserId)
                    .HasConstraintName("FK_dbo.ViewerLicenseUsage_dbo.User_User_UserId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
