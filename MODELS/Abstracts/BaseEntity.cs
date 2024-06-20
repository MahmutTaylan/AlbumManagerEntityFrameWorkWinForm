using MODELS.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MODELS.Abstracts
{
    public  abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreationDate = DateTime.Now; 
        }

        public DateTime CreationDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Status? Status { get; set; }
    }
}
