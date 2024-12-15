# Northwind N Katmanlı Mimari Projesi

## Proje Hakkında

Bu proje, klasik Northwind veritabanının N katmanlı mimari prensiplerine uygun bir şekilde geliştirilmiş bir örneğidir. İş mantığı, veri erişim ve sunum katmanları ayrılarak daha modüler ve sürdürülebilir bir yapı elde edilmiştir.

Proje, yazılım geliştiricilere temiz kod, SOLID prensipleri ve katmanlı mimari uygulamaları konusunda örnek bir altyapı sunmayı amaçlar.

## Teknik Detaylar

- **Katmanlı Mimari**:

  - **Presentation Layer (Sunum Katmanı)**: Kullanıcıdan gelen isteklerin alındığı ve yanıtlandığı katman. Genellikle MVC yapısı kullanılmıştır.
  - **Business Layer (İş Mantığı Katmanı)**: Uygulamanın ış kurallarını ve mantığını yürüten katman.
  - **Data Access Layer (Veri Erişim Katmanı)**: Veritabanı ile ilgili tüm işlemlerin yapıldığı katman.

- **Veritabanı**:

  - **Northwind** veritabanı temel alınmıştır.
  - Entity Framework Core kullanılarak ORM yapısı entegre edilmiştir.

- **Proje Yapısı**:

  - Katmanlar arısında gevşek bağlılık (loose coupling) sağlanmıştır.
  - Dependency Injection ve Interface tabanlı yaklaşım benimsenmiştir.

- **Teknolojiler**:

  - .NET Core Framework
  - Entity Framework Core



## Proje İçeriği

- **Kategori Yönetimi**

  - Yeni kategori ekleme
  - Var olan kategorileri listeleme ve güncelleme
  - Kategori silme

- **Ürün Yönetimi**

  - Ürün ekleme
  - Stok bilgisi güncelleme
  - Fiyat düzenleme

- **Sipariş Takibi**

  - Müşteri bazlı sipariş görüntüleme
  - Sipariş durumlarını izleme

## Katmanlı Mimari Avantajları

- **Modüler Yapı**: Her katman kendi sorumluluklarını yerine getirir, bu sayede kod daha okunabilir ve bakımı kolay olur.
- **Bağımsızlık**: Katmanlar birbirinden bağımsız olarak geliştirilebilir ve test edilebilir.
- **Yeniden Kullanım**: İş mantığı ve veri erişim katmanları, farklı projelerde kolayca yeniden kullanılabilir.

## Kurulum

### Gereksinimler

- .NET SDK
- SQL Server

### Adımlar

1. Repoyu klonlayın:

   ```bash
   git clone https://github.com/berkmahim/DotNetCore.git
   cd DotNetCore
   ```

2. Veritabanınızı hazırlayın ve `appsettings.json` dosyasında bağlantı dizgisini güncelleyin:

   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=.;Database=NorthwindDb;Trusted_Connection=True;"
   }
   ```

3. Migration işlemini tamamlayın ve veritabanını güncelleyin:

   ```bash
   dotnet ef database update
   ```

4. Projeyi çalıştırın:

   ```bash
   dotnet run
   ```

## Proje Yapısı

```
NorthwindProject/
├── /WebAPI                    # Uygulamayı dışarıya açan katman
├── Business/             # İş mantığını yürüten katman
├── DataAccess/           # Veri erişim ve ORM
├── Entities/                  # Veri modelleri ve DTO'\lar
└── Program.cs                 # Uygulama giris noktasi


## Lisans

Bu proje MIT lisansı altında sunulmaktadır. Daha fazla bilgi için `LICENSE` dosyasını inceleyin.

