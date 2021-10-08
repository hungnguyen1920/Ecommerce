using Ecommerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.Property(x => x.FirstName)
                   .IsRequired()
                   .HasMaxLength(200);
            builder.Property(x => x.LastName)
                   .IsRequired()
                   .HasMaxLength(200);
            builder.Property(x => x.DOB)
                   .IsRequired();
        }
    }
}