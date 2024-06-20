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
    public class Album_CFG : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(a => a.AlbumId);
            builder.Property(a => a.AlbumName).IsRequired().HasColumnType("nvarchar").HasMaxLength(150);
            builder.Property(a => a.AlbumSingerGroup).IsRequired().HasColumnType("nvarchar").HasMaxLength(150);
            builder.Property(a => a.AlbumReleaseDate).IsRequired().HasColumnType("datetime2");
            builder.Property(a => a.AlbumPrice).IsRequired().HasColumnType("money");
            builder.Property(a => a.DiscountRate).IsRequired();
            builder.Property(a => a.IsItOnSale).IsRequired();
        }
    }
}
