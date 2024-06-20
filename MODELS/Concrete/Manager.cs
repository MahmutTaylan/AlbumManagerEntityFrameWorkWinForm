using MODELS.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS.Concrete
{
    public class Manager : BaseEntity
    {
        public int ManagerId { get; set; }

        public string ManagerName { get; set; }

        public string ManagerLastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }      

        public IList<AlbumManager> AlbumManagers { get; set; } //Navigation Property
    }
}
