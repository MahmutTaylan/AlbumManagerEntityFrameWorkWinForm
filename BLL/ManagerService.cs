using DAL.Repositories.Concrete;
using MODELS.Concrete;
using MODELS.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ManagerService
    {
        public ManagerService()
        {
            managerRepository = new ManagerRepository(new DAL.Context.AlbumManagerDBContext());
        }
        ManagerRepository managerRepository;

        public bool Add(Manager manager)
        {
            manager.CreationDate = DateTime.Now;
            manager.Status = Status.Active;
            return managerRepository.Add(manager);
        }

        public bool Update(Manager manager)
        {
            manager.Status = Status.Modified;
            manager.ModifiedDate = DateTime.Now;
            return managerRepository.Update(manager);
        }

        public bool Delete(int id) //silme işlmei
        {
            Manager manager = GetById(id);
            return managerRepository.Delete(manager);
        }

        public Manager GetById(int id) //istenilen id deki yöneticiyi bulur
        {
            return managerRepository.Find(id);
        }

        public List<Manager> GetAll() //Butun yoneticileri listeler
        {
            return managerRepository.GetAll();
        }
        public Manager Control(string email, string password)
        {
            // Veritabanında, verilen e-posta ve parola ile eşleşen ilk kullanıcıyı bulur.
            return managerRepository.Control(email, password);
        }

        public Manager UserByUserId(int userId) // Veritabanında, belirtilen kullanıcı kimliği (userId) ile eşleşen ilk yöneticiyi bulur.
        {
            return managerRepository.UserByUserId(userId);
        }

        public bool RegisterControl(string email) // Veritabanında, belirtilen e-posta adresiyle eşleşen herhangi bir yönetici var mı kontrol eder.
        {
            return managerRepository.RegisterControl(email);

        }
        public List<Manager> GetUsers() // Veritabanında, durumu "Aktif" olan tüm yöneticileri alır ve döndürür.
        {
            return managerRepository.GetUsers();
        }

        public bool CheckEmailEntries(string email)  // Veritabanında belirtilen email adıyla eşleşen bir email var mı kontrol eder.
        {
            return managerRepository.CheckEmailEntries(email);
        }


    }
}
