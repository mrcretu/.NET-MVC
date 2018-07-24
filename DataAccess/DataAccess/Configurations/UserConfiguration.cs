using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).HasMaxLength(50);

            builder.Property(u => u.Name).IsRequired().HasMaxLength(100);
            builder.Property(u => u.Email).IsRequired().HasMaxLength(100);

            builder.HasData(

                new User()
                {
                    Id = Guid.NewGuid(),
                    Email = "john_doe@centric.eu",
                    Name = "Jon Doe"

                },
                new User()
                {
                    Id = Guid.NewGuid(),
                    Email = "vic_boss_de_boss@centric.eu",
                    Name = "Victor Pantelemon"

                });
        }
    }
}
