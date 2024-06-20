# Plak Dükkânı Yönetici Modülü

 # Genel Bakış
 
Bu proje, albüm plakları satan bir dükkânı yönetmek için Windows Form uygulamasıdır. "Code First" yaklaşımı ile "Entity Framework" teknolojisini kullanmaktadır. Uygulama, yöneticilerin giriş yapabileceği, albüm ekleyip güncelleyebileceği, silebileceği ve yeni yönetici hesapları oluşturabileceği bir yönetici modülünü içerir. Proje katmanlı mimari ile yapılandırılmıştır ve BLL, DAL, MODELS, PL katmanlarına sahiptir. Ayrıca servis ve repository desenleri kullanılmıştır.

# Katmanlı Mimari

# DAL (Data Access Layer)

Veritabanı işlemlerini yönetir.

Entity Framework ile veritabanı etkileşimlerini gerçekleştirir.

Repository deseni kullanılarak veri erişim katmanı soyutlanmıştır.

# BLL (Business Logic Layer)

İş mantığını içerir.

DAL katmanından verileri alır ve iş kurallarını uygular.

Servis katmanı ile PL katmanına veri sağlar.

# MODELS

Proje boyunca kullanılan veri modellerini içerir.

Albüm, kullanıcı ve diğer gerekli veri modellerini tanımlar.

# PL (Presentation Layer)
Kullanıcı arayüzünü sağlar (Windows Forms).

Kullanıcıların sistemle etkileşime girdiği katmandır.

BLL katmanındaki servisler ile iletişim kurar.

# Özellikler

# Yönetici Giriş Bölümü

Yöneticiler, kullanıcı adı ve şifreleri ile giriş yapabilirler.

Giriş bilgilerinin yanlış olması durumunda hata mesajı gösterilir.

Yöneticilerin albüm ekleme, güncelleme ve silme işlemlerini yapabileceği fonksiyonlar sağlar.

Yeni yönetici kayıt işlemi yapılabilir.

Yeni yönetici kaydı sırasında, kullanıcı adı benzersiz olmalı ve şifre belirtilen kriterlere uygun olmalıdır.

Şifreler, veri tabanında güvenli bir şekilde SHA-256 algoritması kullanılarak saklanır.

# Ana Bölüm

Albüm ekleme, güncelleme ve silme işlemleri yapılabilir.

Tüm albümlerin detaylı listesi görüntülenebilir (albüm adı, sanatçı/grup, çıkış tarihi, fiyatı, indirim oranı, satış durumu).

# Ayrı listelerde görüntüleme:

Satışı durmuş albümler (sadece albüm adı ve sanatçı/grup)

Satışı devam eden albümler (sadece albüm adı ve sanatçı/grup)

Sisteme en son eklenen 10 albüm (sadece albüm adı ve sanatçı/grup)

İndirimdeki albümler (sadece albüm adı ve sanatçı/grup), indirim oranına göre azalan sırada

# Albüm Bilgileri

Albüm adı

Sanatçı/Grup

Çıkış tarihi

Fiyat

İndirim oranı (varsa)

Satış durumu (satışta olup olmadığı)

# Şifre Kriterleri

En az 8 karakter uzunluğunda olmalıdır.

En az 2 büyük harf içermelidir.

En az 3 küçük harf içermelidir.

! (ünlem), : (iki nokta üst üste), + (artı), * (yıldız) karakterlerinden en az 2 tanesini içermelidir. (Aynı karakterden birden fazla olabilir)

# Projeyi Çalıştırma
Projeyi yerel makinenize klonlayın.

Visual Studio'da projeyi açın.

NuGet paketlerini geri yükleyin.

Entity Framework Code First Migrations kullanarak veritabanını güncelleyin.

Projeyi derleyip çalıştırın.

# Yönetici Kayıt İşlemi

Yönetici kayıt bölümüne gidin.

Benzersiz bir kullanıcı adı girin.

Belirtilen kriterlere uygun bir şifre girin.

Şifreyi doğrulama alanına tekrar girin.

Kullanıcı adı benzersiz ve şifreler eşleşiyorsa, yeni yönetici hesabı oluşturulur.

# Yönetici Giriş İşlemi

Yönetici giriş bölümüne gidin.

Kullanıcı adı ve şifre girin.

Girilen şifre hashlenerek veri tabanındaki hashlenmiş şifre ile karşılaştırılır.

Bilgiler doğruysa sisteme giriş izni verilir, değilse hata mesajı gösterilir.

# Yönetici Albüm Yönetimi

Albüm Ekleme: Albüm bilgilerini girin ve 'Ekle' butonuna tıklayarak albümü veri tabanına kaydedin.

Albüm Güncelleme: Listeden bir albüm seçin, bilgileri güncelleyin ve 'Güncelle' butonuna tıklayın.

Albüm Silme: Listeden bir albüm seçin ve 'Sil' butonuna tıklayarak albümü veri tabanından kaldırın.

Liste Görüntüleme: Ana bölümde tüm albümleri veya belirli listeleri görüntüleyin (satışı devam eden albümler, yeni eklenen albümler, indirimdeki albümler).
