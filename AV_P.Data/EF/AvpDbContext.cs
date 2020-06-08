using AV_P.Data.Configurations;
using AV_P.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV_P.Data.EF
{
    public class AvpDbContext : DbContext
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
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductInCategory> ProductInCategories { get; set; }
        public DbSet<AppConfig> AppConfigs { get; set; }
        public DbSet<CategoryTranslation> CategoryTranslations { get; set; }
        public DbSet<ProductTranslation> ProductTranslations { get; set; }
        public DbSet<Language> Languages { get; set; }
    }
}
