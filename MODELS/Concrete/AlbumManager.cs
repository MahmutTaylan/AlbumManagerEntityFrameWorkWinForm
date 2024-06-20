using MODELS.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS.Concrete
{
    public class AlbumManager : BaseEntity
    {
        public int ManagerId { get; set; }

        public int AlbumId { get; set; }

        public Album Album { get; set; }  

        public Manager Manager { get; set; }
    }
}

