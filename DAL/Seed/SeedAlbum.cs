using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MODELS.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Seed
{
    public class SeedAlbum : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasData // Veri Girişi
                (
                new Album { AlbumId = 1, AlbumName = "Tamirci Çıragı", AlbumSingerGroup = "Cem Karaca", AlbumReleaseDate = new DateTime(1997, 3, 29), AlbumPrice = 200, DiscountRate = 15, IsItOnSale = false, Status = MODELS.Enums.Status.Active },
                new Album { AlbumId = 2, AlbumName = "Thriller", AlbumSingerGroup = "Michael Jackson", AlbumReleaseDate = new DateTime(1982, 11, 30), AlbumPrice = 200, DiscountRate = 10, IsItOnSale = true, Status = MODELS.Enums.Status.Active },
                new Album { AlbumId = 3, AlbumName = "Thriller", AlbumSingerGroup = "Michael Jackson", AlbumReleaseDate = new DateTime(1982, 11, 30), AlbumPrice = 200, DiscountRate = 10, IsItOnSale = true, Status = MODELS.Enums.Status.Active },
                new Album { AlbumId = 4, AlbumName = "Dark Side of the Moon", AlbumSingerGroup = "Pink Floyd", AlbumReleaseDate = new DateTime(1973, 3, 1), AlbumPrice = 250, DiscountRate = 15, IsItOnSale = false, Status = MODELS.Enums.Status.Active },
                new Album { AlbumId = 5, AlbumName = "The Wall", AlbumSingerGroup = "Pink Floyd", AlbumReleaseDate = new DateTime(1979, 11, 30), AlbumPrice = 300, DiscountRate = 20, IsItOnSale = true, Status = MODELS.Enums.Status.Active },
                new Album { AlbumId = 6, AlbumName = "Back in Black", AlbumSingerGroup = "AC/DC", AlbumReleaseDate = new DateTime(1980, 7, 25), AlbumPrice = 220, DiscountRate = 12, IsItOnSale = true, Status = MODELS.Enums.Status.Active },
                new Album { AlbumId = 7, AlbumName = "Abbey Road", AlbumSingerGroup = "The Beatles", AlbumReleaseDate = new DateTime(1969, 9, 26), AlbumPrice = 280, DiscountRate = 18, IsItOnSale = false, Status = MODELS.Enums.Status.Active },
                new Album { AlbumId = 8, AlbumName = "The Eminem Show", AlbumSingerGroup = "Eminem", AlbumReleaseDate = new DateTime(2002, 5, 28), AlbumPrice = 210, DiscountRate = 14, IsItOnSale = true, Status = MODELS.Enums.Status.Active },
                new Album { AlbumId = 9, AlbumName = "Hotel California", AlbumSingerGroup = "Eagles", AlbumReleaseDate = new DateTime(1976, 12, 8), AlbumPrice = 260, DiscountRate = 17, IsItOnSale = false, Status = MODELS.Enums.Status.Active },
                new Album { AlbumId = 10, AlbumName = "Led Zeppelin IV", AlbumSingerGroup = "Led Zeppelin", AlbumReleaseDate = new DateTime(1971, 11, 8), AlbumPrice = 240, DiscountRate = 16, IsItOnSale = true, Status = MODELS.Enums.Status.Active },
                new Album { AlbumId = 11, AlbumName = "The Queen Is Dead", AlbumSingerGroup = "The Smiths", AlbumReleaseDate = new DateTime(1986, 6, 16), AlbumPrice = 290, DiscountRate = 19, IsItOnSale = false, Status = MODELS.Enums.Status.Active },
                new Album { AlbumId = 12, AlbumName = "Nevermind", AlbumSingerGroup = "Nirvana", AlbumReleaseDate = new DateTime(1991, 9, 24), AlbumPrice = 270, DiscountRate = 20, IsItOnSale = true, Status = MODELS.Enums.Status.Active },
                new Album { AlbumId = 13, AlbumName = "Future Nostalgia", AlbumSingerGroup = "Dua Lipa", AlbumReleaseDate = new DateTime(2020, 3, 27), AlbumPrice = 25, DiscountRate = 10, IsItOnSale = true, Status = MODELS.Enums.Status.Active },
                new Album { AlbumId = 14, AlbumName = "Positions", AlbumSingerGroup = "Ariana Grande", AlbumReleaseDate = new DateTime(2020, 10, 30), AlbumPrice = 28, DiscountRate = 15, IsItOnSale = false, Status = MODELS.Enums.Status.Active },
                new Album { AlbumId = 15, AlbumName = "evermore", AlbumSingerGroup = "Taylor Swift", AlbumReleaseDate = new DateTime(2020, 12, 11), AlbumPrice = 30, DiscountRate = 20, IsItOnSale = true, Status = MODELS.Enums.Status.Active },
                new Album { AlbumId = 16, AlbumName = "After Hours", AlbumSingerGroup = "The Weeknd", AlbumReleaseDate = new DateTime(2020, 3, 20), AlbumPrice = 22, DiscountRate = 12, IsItOnSale = true, Status = MODELS.Enums.Status.Active },
                new Album { AlbumId = 17, AlbumName = "Fine Line", AlbumSingerGroup = "Harry Styles", AlbumReleaseDate = new DateTime(2019, 12, 13), AlbumPrice = 28, DiscountRate = 18, IsItOnSale = false, Status = MODELS.Enums.Status.Active },
                new Album { AlbumId = 18, AlbumName = "30", AlbumSingerGroup = "Adele", AlbumReleaseDate = new DateTime(2021, 11, 19), AlbumPrice = 25, DiscountRate = 10, IsItOnSale = true, Status = MODELS.Enums.Status.Active },
                new Album { AlbumId = 19, AlbumName = "Justice", AlbumSingerGroup = "Justin Bieber", AlbumReleaseDate = new DateTime(2021, 3, 19), AlbumPrice = 28, IsItOnSale = false, Status = MODELS.Enums.Status.Active },
                new Album { AlbumId = 20, AlbumName = "Happier Than Ever", AlbumSingerGroup = "Billie Eilish", AlbumReleaseDate = new DateTime(2021, 7, 30), AlbumPrice = 30, DiscountRate = 20, IsItOnSale = true, Status = MODELS.Enums.Status.Active },
                new Album { AlbumId = 21, AlbumName = "Montero", AlbumSingerGroup = "Lil Nas X", AlbumReleaseDate = new DateTime(2021, 9, 17), AlbumPrice = 22, DiscountRate = 12, IsItOnSale = true, Status = MODELS.Enums.Status.Active },
                new Album { AlbumId = 22, AlbumName = "Red (Taylor's Version)", AlbumSingerGroup = "Taylor Swift", AlbumReleaseDate = new DateTime(2021, 11, 12), AlbumPrice = 28, IsItOnSale = false, Status = MODELS.Enums.Status.Active },
                new Album { AlbumId = 23, AlbumName = "Karanlıkta", AlbumSingerGroup = "Duman", AlbumReleaseDate = new DateTime(2023, 2, 14), AlbumPrice = 25, DiscountRate = 15, IsItOnSale = true, Status = MODELS.Enums.Status.Active },
                new Album { AlbumId = 24, AlbumName = "Düşler Ülkesinin Gelgit Akşamları", AlbumSingerGroup = "Müslüm Gürses", AlbumReleaseDate = new DateTime(2023, 4, 25), AlbumPrice = 28, IsItOnSale = false, Status = MODELS.Enums.Status.Active },
                new Album { AlbumId = 25, AlbumName = "Aşk Masalı", AlbumSingerGroup = "Sezen Aksu", AlbumReleaseDate = new DateTime(2023, 6, 10), AlbumPrice = 30, DiscountRate = 20, IsItOnSale = true, Status = MODELS.Enums.Status.Active },
                 new Album { AlbumId = 26, AlbumName = "Yaş Hikayesi", AlbumSingerGroup = "Cem Adrian", AlbumReleaseDate = new DateTime(2023, 8, 3), AlbumPrice = 22, DiscountRate = 18, IsItOnSale = true, Status = MODELS.Enums.Status.Active },
                 new Album { AlbumId = 27, AlbumName = "Senin İçin Değer", AlbumSingerGroup = "Kenan Doğulu", AlbumReleaseDate = new DateTime(2023, 9, 17), AlbumPrice = 28, DiscountRate = 12, IsItOnSale = true, Status = MODELS.Enums.Status.Active },
                 new Album { AlbumId = 28, AlbumName = "Gel Yeter", AlbumSingerGroup = "Ajda Pekkan", AlbumReleaseDate = new DateTime(2023, 11, 5), AlbumPrice = 26, DiscountRate = 15, IsItOnSale = false, Status = MODELS.Enums.Status.Active },
                 new Album { AlbumId = 29, AlbumName = "Sorma Neden", AlbumSingerGroup = "Tarkan", AlbumReleaseDate = new DateTime(2023, 12, 24), AlbumPrice = 32, DiscountRate = 10, IsItOnSale = true, Status = MODELS.Enums.Status.Active },
                 new Album { AlbumId = 30, AlbumName = "Düşler Sokağı", AlbumSingerGroup = "Gülşen", AlbumReleaseDate = new DateTime(2024, 2, 8), AlbumPrice = 24, DiscountRate = 18, IsItOnSale = false, Status = MODELS.Enums.Status.Active },
                 new Album { AlbumId = 31, AlbumName = "Son Şarkılarım", AlbumSingerGroup = "Teoman", AlbumReleaseDate = new DateTime(2024, 4, 13), AlbumPrice = 29, DiscountRate = 10, IsItOnSale = true, Status = MODELS.Enums.Status.Active },
                  new Album { AlbumId = 32, AlbumName = "Bir Zamanlar Türkiye'de", AlbumSingerGroup = "MFÖ", AlbumReleaseDate = new DateTime(2024, 6, 29), AlbumPrice = 27, DiscountRate = 15, IsItOnSale = false, Status = MODELS.Enums.Status.Active },
                  new Album { AlbumId = 33, AlbumName = "İstanbul Hatırası", AlbumSingerGroup = "Müzeyyen Senar", AlbumReleaseDate = new DateTime(2023, 10, 10), AlbumPrice = 25, IsItOnSale = true, Status = MODELS.Enums.Status.Active },
                  new Album { AlbumId = 34, AlbumName = "Köprüaltı Çocukları", AlbumSingerGroup = "Barış Manço", AlbumReleaseDate = new DateTime(2023, 11, 21), AlbumPrice = 28, IsItOnSale = true, Status = MODELS.Enums.Status.Active }

                  );

        }
    }
}
