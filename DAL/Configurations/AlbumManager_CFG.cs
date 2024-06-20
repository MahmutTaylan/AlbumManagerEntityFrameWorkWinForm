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
    public class AlbumManager_CFG : IEntityTypeConfiguration<AlbumManager>
    {
        public void Configure(EntityTypeBuilder<AlbumManager> builder)
        {
            builder.HasKey(x => new { x.AlbumId, x.ManagerId });
        }
    }
}
