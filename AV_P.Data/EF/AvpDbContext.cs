﻿using AV_P.Data.Configurations;
using AV_P.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace AV_P.Data.EF
{
    public class AvpDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public AvpDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration( new AppConfigConfiguration() );
            modelBuilder.ApplyConfiguration( new CategoryConfiguration() );
            modelBuilder.ApplyConfiguration( new ProductConfiguration() );
            modelBuilder.ApplyConfiguration( new ProductInCategoryConfiguration() );
            modelBuilder.ApplyConfiguration( new LanguageConfiguration() );
            modelBuilder.ApplyConfiguration( new ProductTranslationConfiguration() );
            modelBuilder.ApplyConfiguration( new CategoryTranslationConfiguration() );
            modelBuilder.ApplyConfiguration(new ProductImageConfiguration());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductInCategory> ProductInCategories { get; set; }
        public DbSet<AppConfig> AppConfigs { get; set; }
        public DbSet<CategoryTranslation> CategoryTranslations { get; set; }
        public DbSet<ProductTranslation> ProductTranslations { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
    }
}
