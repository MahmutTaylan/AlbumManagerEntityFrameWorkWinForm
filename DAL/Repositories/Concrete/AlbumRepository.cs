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
    public class AlbumRepository : Crud<Album>
    {
        public AlbumRepository(AlbumManagerDBContext dbContext) : base(dbContext)
        {
            _dbContext = new AlbumManagerDBContext();

        }

        AlbumManagerDBContext _dbContext;
        public List<Album> GetAllAlbums() //Tum albumleri Listele
        {
            return _dbContext.Albums.ToList();
        }
        public List<Album> GetAlbumNameAndSinger() //Albumleri Album adi ve Şarkıcısına göre listele
        {
            return _dbContext.Albums
                .Select(a => new Album {AlbumName = a.AlbumName, AlbumSingerGroup = a.AlbumSingerGroup}).ToList();
        }

        public Album GetAlbumById(int id) // İlgili Id'ye sahip albümü veritabanından alır ve döndürür.
        {
            return _dbContext.Albums.Where(x => x.AlbumId == id).ToList().FirstOrDefault();
        }

        public List<Album> GetAlbumsOnSale()
        {
            // Veritabanında, satısda olan albumlerı, sadece albüm adı ve sanatçısıyla birlikte listeler ve döndürür.
            return _dbContext.Albums
                              .Where(x => x.IsItOnSale == true && x.Status !=Status.Passive)
                              .Select(x => new Album { AlbumName = x.AlbumName, AlbumSingerGroup = x.AlbumSingerGroup })
                              .ToList();
        }
        public List<Album> GetAlbumsNotSale()
        {
            // Veritabanında, satısda olmayan albumlerı, sadece albüm adı ve sanatçısıyla birlikte listeler ve döndürür.
            return _dbContext.Albums
                              .Where(x => x.IsItOnSale == false)
                              .Select(x => new Album { AlbumName = x.AlbumName, AlbumSingerGroup = x.AlbumSingerGroup })
                              .ToList();
        }

        public List<Album> GetLastTenAddedAlbums() // sisteme eklenen en son 10 album
        {
            // Sisteme en son eklenen 10 albümün sadece albüm adı ve sanatçı bilgilerini alır ve döndürür.
            return _dbContext.Albums
                              .Where(x => x.Status != Status.Passive)
                              .OrderByDescending(x => x.CreationDate) // Tarihe göre en son eklenen albümleri sıralar
                              .Take(10) // İlk 10 albümü seçer
                              .Select(x => new Album { AlbumName = x.AlbumName, AlbumSingerGroup = x.AlbumSingerGroup }) // Sadece albüm adı ve sanatçı bilgilerini seçer
                              .ToList();
        }

        public List<Album> GetAlbumsOnSaleOrderByDiscount() // indirimdeki albumler
        {
            // İndirimdeki albümleri, indirim oranına göre sıralanmış şekilde sadece albüm adı ve sanatçı/grup bilgileriyle birlikte alır ve döndürür.
            return _dbContext.Albums
                              .Where(x => x.Status != Status.Passive && x.IsItOnSale == true) // İndirimde olan albümleri filtreler
                              .OrderByDescending(x => x.DiscountRate) // İndirim oranına göre büyükten küçüğe sıralar
                              .Select(x => new Album { AlbumName = x.AlbumName, AlbumSingerGroup = x.AlbumSingerGroup }) // Sadece albüm adı ve sanatçı/grup bilgilerini seçer
                              .ToList();
        }

    }
}
