using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MODELS.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class Manager_CFG : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.ToTable("Managers");
            builder.HasKey(u => u.ManagerId);
            builder.Property(u => u.ManagerName).IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            builder.Property(u => u.ManagerLastName).IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            builder.Property(u => u.Email).IsRequired().HasColumnType("nvarchar").HasMaxLength(75);
            builder.Property(u => u.Password).IsRequired().HasColumnType("nvarchar").HasMaxLength(300);
        }
    }
}
