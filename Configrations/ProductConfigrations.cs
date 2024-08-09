using crud_task.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_task.Configurations
{
    internal class ProductConfigrations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
           
            builder.Property(p => p.Name).HasColumnType("varchar(30)");  
            builder.Property(p => p.Price).HasColumnType("decimal(18,2)");
            builder.HasKey(p => p.Id);




        }
    }
}
