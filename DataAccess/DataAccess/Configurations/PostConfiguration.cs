using System;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Posts");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasMaxLength(50);

            builder.Property(p => p.AddedDate).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(p => p.Content).IsRequired().HasMaxLength(1000);

            builder.HasOne(p => p.User).WithMany(u => u.Posts).HasForeignKey(p => p.UserId);
            builder.Property(u => u.Id).HasMaxLength(50);

           
        }
    }
}
