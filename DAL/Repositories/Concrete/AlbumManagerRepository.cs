using DAL.Context;
using Microsoft.EntityFrameworkCore;
using MODELS.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Concrete
{
    public class AlbumManagerRepository : Crud<AlbumManager>
    {
        public AlbumManagerRepository(AlbumManagerDBContext dbContext) : base(dbContext)
        {
            _dbContext = new AlbumManagerDBContext();

        }
        AlbumManagerDBContext _dbContext;
    }
}
