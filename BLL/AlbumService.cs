using DAL.Repositories.Concrete;
using Microsoft.EntityFrameworkCore;
using MODELS.Concrete;
using MODELS.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AlbumService
    {
        public AlbumService()
        {
            albumRepository = new AlbumRepository(new DAL.Context.AlbumManagerDBContext());
        }
        AlbumRepository albumRepository;

        public bool Add(Album album)
        {
            album.CreationDate = DateTime.Now;
            album.Status = Status.Active;
            return albumRepository.Add(album);
        }

        public bool Update(Album album)
        {
            album.Status = Status.Modified;
            album.ModifiedDate = DateTime.Now;
            return albumRepository.Update(album);
        }

        public bool Delete(int id)
        {
            Album album = GetById(id);
            return albumRepository.Delete(album);
        }

        public Album GetById(int id)
        {
            return albumRepository.Find(id);
        }

        public List<Album> GetAll()
        {
            return albumRepository.GetAll();
        }
        public List<Album> GetAllAlbums() //Tum albumleri Listele
        {
            return albumRepository.GetAllAlbums();
        }

        public Album GetAlbumById(int id) // İlgili Id'ye sahip albümü veritabanından alır ve döndürür.
        {
            return albumRepository.GetAlbumById(id);
        }

        public List<Album> GetAlbumsOnSale()
        {
            // Veritabanında, satısda olan albumlerı, sadece albüm adı ve sanatçısıyla birlikte listeler ve döndürür.
            return albumRepository.GetAlbumsOnSale();
        }
        public List<Album> GetAlbumsNotSale()
        {
            // Veritabanında, satısda olmayan albumlerı, sadece albüm adı ve sanatçısıyla birlikte listeler ve döndürür.
            return albumRepository.GetAlbumsNotSale();
        }
        public List<Album> GetLastTenAddedAlbums() // sisteme eklenen en son 10 album
        {
            return albumRepository.GetLastTenAddedAlbums();
        }

        public List<Album> GetAlbumsOnSaleOrderByDiscount() // indirimdeki albumler
        {
            return albumRepository.GetAlbumsOnSaleOrderByDiscount();
        }

        public List<Album> GetAlbumNameAndSinger() //Albumleri Album adi ve Şarkıcısına göre listele
        {
            return albumRepository.GetAlbumNameAndSinger();
        }
    }
}