using crud_task.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_task.models
{
    internal class Order
    {
        public int Id { get; set; }
        public string adress { get; set; }
        public DateTime createdAt { get; set; }

    }
}
*/
namespace crud_task.Configurations
{
    internal class OrderConfigrations : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(o => o.adress).HasColumnType("varchar(100)");
            builder.Property(o => o.createdAt).HasComputedColumnSql("GETDATE()");
            builder.HasKey(o => o.Id);



        }
    }
}
