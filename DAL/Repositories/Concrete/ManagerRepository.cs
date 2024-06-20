using DAL.Context;
using Microsoft.EntityFrameworkCore;
using MODELS.Concrete;
using MODELS.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Concrete
{
    public class ManagerRepository : Crud<Manager>
    {
        public ManagerRepository(AlbumManagerDBContext dbContext) : base(dbContext)
        {
            _dbContext = new AlbumManagerDBContext();

        }
        AlbumManagerDBContext _dbContext;

        public Manager Control(string email, string password)
        {
            // Veritabanında, verilen e-posta ve parola ile eşleşen ilk kullanıcıyı bulur.
            return _dbContext.Managers.AsNoTracking().FirstOrDefault(x => x.Email == email && x.Password == password);
        }

        public Manager UserByUserId(int userId) // Veritabanında, belirtilen kullanıcı kimliği (userId) ile eşleşen ilk yöneticiyi bulur.
        {
            return _dbContext.Managers.FirstOrDefault(x => x.ManagerId == userId);
        }

        public bool RegisterControl(string email) // Veritabanında, belirtilen e-posta adresiyle eşleşen herhangi bir yönetici var mı kontrol eder.
        {
            return _dbContext.Managers.AsNoTracking().Any(x => x.Email == email);
        }

        public List<Manager> GetUsers() // Veritabanında, durumu "Aktif" olan tüm yöneticileri alır ve döndürür.
        {
            return _dbContext.Managers.Where(x => x.Status == Status.Active).ToList();
        }

        public bool CheckEmailEntries(string email)  // Veritabanında belirtilen email adıyla eşleşen bir email var mı kontrol eder.
        {
            var maEmail = _dbContext.Managers.FirstOrDefault(x => x.Email == email);
            if (maEmail == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
