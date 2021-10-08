using System;
using Ecommerce.Data.Configurations;
using Ecommerce.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data.EF
{
    public class EcommerceDbContext : IdentityDbContext<User, Role, Guid>
    {
        public EcommerceDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder moderBuilder)
        {
            moderBuilder.ApplyConfiguration(new AppConfigConfiguration());
            moderBuilder.ApplyConfiguration(new ProductConfiguration());
            moderBuilder.ApplyConfiguration(new CategoryConfiguration());
            moderBuilder.ApplyConfiguration(new OrderConfiguration());
            moderBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            moderBuilder.ApplyConfiguration(new CategoryTranslationConfiguration());
            moderBuilder.ApplyConfiguration(new ContactConfiguration());
            moderBuilder.ApplyConfiguration(new LanguageConfiguration());
            moderBuilder.ApplyConfiguration(new ProductTranslationConfiguration());
            moderBuilder.ApplyConfiguration(new PromotionConfiguration());
            moderBuilder.ApplyConfiguration(new TransactionConfiguration());
            moderBuilder.ApplyConfiguration(new UserConfiguration());
            moderBuilder.ApplyConfiguration(new RoleConfiguration());

            moderBuilder.ApplyConfiguration(new ProductCategoryMapConfiguration());

            moderBuilder.Entity<IdentityUserClaim<Guid>>()
                        .ToTable("AppUserClainms");
            moderBuilder.Entity<IdentityUserRole<Guid>>()
                        .ToTable("AppUserRoles")
                        .HasKey(x => new { x.RoleId, x.UserId });
            moderBuilder.Entity<IdentityUserLogin<Guid>>()
                        .ToTable("AppUserLogins")
                        .HasKey(x => x.UserId);
            moderBuilder.Entity<IdentityRoleClaim<Guid>>()
                        .ToTable("AppRoleClaims");
            moderBuilder.Entity<IdentityUserToken<Guid>>()
                        .ToTable("AppUserTokens")
                        .HasKey(x => x.UserId);
            //base.OnModelCreating(moderBuilder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AppConfig> AppConfigs { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CategoryTranslation> CategoryTranslations { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ProductTranslation> ProductTranslations { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<ProductCategoryMap> ProductCategoryMaps { get; set; }
    }
}