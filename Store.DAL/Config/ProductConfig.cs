using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.DAL.Entities;

namespace Store.DAL.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.HasIndex(x => x.Id)
                .IsUnique();
            builder.Property(x => x.Category)
                   .HasDefaultValue("Undefined")
                   .HasMaxLength(100);
            builder.Property(x => x.Price)
                   .HasColumnType("decimal(18,2)");
            builder.Property(x => x.Stock)
                   .HasPrecision(18, 3);

        }
    }
}
