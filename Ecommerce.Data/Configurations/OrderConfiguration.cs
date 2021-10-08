using System;
using Ecommerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Orders");
            builder.Property(x => x.ShipEmail)
                   .IsRequired()
                   .IsUnicode(false)
                   .HasMaxLength(50);
            builder.Property(x => x.Id)
                   .UseIdentityColumn();
            builder.Property(x => x.OrderDate)
                   .HasDefaultValue(DateTime.Now);
            builder.Property(x => x.ShipAddress)
                   .IsRequired()
                   .HasMaxLength(200);
            builder.Property(x => x.ShipName)
                   .IsRequired()
                   .HasMaxLength(200);
            builder.Property(x => x.ShipPhoneNumber)
                   .IsRequired()
                   .HasMaxLength(200);
            builder.HasOne(x => x.Users)
                   .WithMany(x => x.Orders)
                   .HasForeignKey(x => x.UserId);
        }
    }
}