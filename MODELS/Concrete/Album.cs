using MODELS.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS.Concrete
{
    public class Album : BaseEntity
    {
      
        public int AlbumId { get; set; }

        public string AlbumName { get; set; }

        public string AlbumSingerGroup { get; set; }

        public DateTime AlbumReleaseDate { get; set; }

        public double AlbumPrice { get; set; }

        public double DiscountRate { get; set; }

        public bool IsItOnSale { get; set; }

        public IList<AlbumManager> AlbumManagers { get; set; } //Navigation Property
    }
}
