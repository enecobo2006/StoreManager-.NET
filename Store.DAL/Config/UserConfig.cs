using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.DAL.Entities;

namespace Store.DAL.Config
{
    internal class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Email)
                   .IsRequired()
                   .HasMaxLength(200);
            builder.HasIndex(x => x.Email)
                   .IsUnique();

            builder.Property(x => x.Password)
                   .HasMaxLength(200);
        }
    }
}
