# Kütüphane Takip Uygulaması

Bu uygulama, bir kütüphanenin envanterini ve ödünç işlemlerini takip etmek için tasarlanmıştır.
.NET Core ile yazılmış bir RESTful API, kütüphane envanterini yönetir ve kullanıcı işlemlerini işler.
Next.js ile yazılmış bir web arayüzü, kullanıcılara kütüphane kitaplarını aramak ve ödünç almak için bir arayüz sunar.
Web arayüzü, .NET Core API'ye istekler yapar ve kullanıcıların etkileşimlerini işler.

## `Entity`'ler

Uygulama aşağıdaki entiteleri içermektedir:

- **AppUser**: Uygulama kullanıcılarının kaydedilmesi ve yönetilmesi.
- **AppRole**: Kullanıcı rollerinin tanımlanması ve yönetilmesi.
- **Staff**: Kütüphane personelinin kaydedilmesi ve yönetilmesi.
- **Member**: Kütüphane üyelerinin kaydedilmesi ve takibi.
- **Library Branch**: Kütüphane şubelerinin kaydedilmesi.
- **LibraryTransaction**: Kütüphane işlemlerinin yönetimi.
- **Branch Hour**: Kütüphane şubelerinin çalışma saatlerinin yönetimi.
- **Book**: Kitapların kaydedilmesi ve yönetilmesi.
- **Genre**: Kitap türlerinin kaydedilmesi.
- **Author**: Kitap yazarlarının kaydedilmesi.
- **Publisher**: Kitap yayınevlerinin kaydedilmesi.
- **Borrow**: Kitap ödünç alma işlemlerinin yönetimi.
- **Return**: Kitap iade işlemlerinin yönetimi.
- **BookStock**: Kitap stoklarının yönetimi.
- **Tag**: Kitapları kategorize etmek için etiketlerin yönetimi.

## Özellikler

- **Kitap ve Kategori Yönetimi**: Kitapların ve kategorilerin kaydedilmesi, düzenlenmesi ve sorgulanması.
- **Üye Yönetimi**: Kütüphane üyelerinin kaydedilmesi ve takibi.
- **Ödünç Alma ve İade İşlemleri**: Kitap ödünç alma, iade etme ve süre uzatma işlemleri.
- **Personel Yönetimi**: Kütüphane personelinin yönetimi ve yetkilendirilmesi.
- **Kütüphane İşlemleri Takibi**: Kütüphane içi işlemlerin detaylı kaydı ve raporlanması.
- **Yönetim ve Raporlama Araçları**: Kapsamlı yönetim ve raporlama araçları.
- **Kullanıcı Hesapları ve İzinler**: Çok kullanıcılı hesap yönetimi ve rol bazlı erişim kontrolleri.

## Ekran Görüntüleri

- **Landing Sayfası**
  ![Landing Page](screenshots/landing-page.png)

- **Kayıt Ol ve Giriş Yap Sayfaları**
  ![Register Page](screenshots/register-page.png) 
  ![Login Page](screenshots/login-page.png) 

- **Uygulama Paneli**
  ![Application Panel](screenshots/app-panel.png)

- **Yazar Sayfası**
  ![Author Page](screenshots/author-page.png)

- **Admin Ana Panel**
  ![Admin Dashboard](screenshots/admin-support-page.png)

- **Admin Destek Sayfası**
  ![Admin Support Page](screenshots/admin-support-page.png)

- **Uygulama Destek Sayfası**
  ![App Support Page](screenshots/app-support-page.png)


- daha eklenecektir güncellendikçe

# Proje Kurulumu

## Kullanılan Teknolojiler

### Frontend

- React
- Next.js
- TypeScript
- Tailwind CSS
- Chakra UI

### Backend

- .NET Core
- MSSQL

### Testler

- Jest
- React Testing Library
- xUnit
- SpecFlow
- Selenium

## Projeyi İndirme

GitHub'dan projeyi alın:

```bash
 git clone https://github.com/ilyasBozdemir/libraryTrackingApp
```

## Backend Kurulumu için:

1. Backend klasörüne gidin (`LibraryTrackingApp/src/backend`).
2. Bilgisayarınızda .NET Core 8 SDK ve Visual Studio yüklü olmalıdır.
3. Bağımlılıkları yüklemek için terminalde aşağıdaki komutu çalıştırın:

```bash
dotnet restore
```

4. Veritabanı bağlantısını güncellemek için Veritabanı bağlantısını güncellemek için [AppConstant.cs](https://github.com/ilyasBozdemir/libraryTrackingApp/blob/case-project/LibraryTrackingApp/src/backend/Core/LibraryTrackingApp.Domain/Constants/AppConstant.cs#L11) dosyasını açın ve `DefaultConnectionString` değişkenindeki bağlantı dizesini güncelleyin. Örneğin:

   ```csharp

   private const string server = "DESKTOP-R4UP5K6\\SQLEXPRESS";
   private const string database = "LibraryTrackingAppDb";
   private const string integratedSecurity = true ? "True" : "False";
   private const string trustServerCertificate = true ? "True" : "False";

   // case için veritabanı baglantısı gercek projede bu şekilde saklanmaz.
   public const string DefaultConnectionString = $"Server={server};Database={database};Integrated Security={integratedSecurity};TrustServerCertificate={trustServerCertificate};";
   ```

5. Veritabanı migrasyonlarını uygulamak için aşağıdaki adımları izleyin:

   a. Terminalde aşağıdaki komutu çalıştırarak Infrastructure ve Persistence projelerinin bulunduğu klasöre gidin:

   ```bash
   cd Infrastructure/LibraryTrackingApp.Persistence
   ```

   b. Aşağıdaki komutu çalıştırarak migrasyonları oluşturun:

   ```bash
   dotnet ef migrations add InitialCreate --startup-project ../../LibraryTrackingApp.WebAPI/LibraryTrackingApp.WebAPI.csproj --context AppIdentityDbContext
   ```

   c. Aşağıdaki komutu çalıştırarak migrasyonları veritabanına uygulayın:

   ```bash
   dotnet ef database update --startup-project ../../LibraryTrackingApp.WebAPI/LibraryTrackingApp.WebAPI.csproj --context AppIdentityDbContext
   ```

6. Proje dizinindeyken, projeyi çalıştırmak için terminalde aşağıdaki komutu çalıştırın:

   ```bash
   dotnet run
   ```

### Frontend Kurulumu için:

1. **Frontend klasörüne gidin** (`LibraryTrackingApp/src/frontend`).
2. Node.js yüklü olmalıdır.
3. Bağımlılıkları yüklemek için terminalde aşağıdaki komutu çalıştırın:

   ```bash
   npm install
   ```

4. Proje dizinindeyken, projeyi çalıştırmak için terminalde aşağıdaki komutu çalıştırın:

   ```bash
   npm run start
   ```

5. Admin sayfası için http://localhost:3000/admin/ sayfasını acın.

## Proje Özellikleri

Proje, çeşitli mimari ve tasarım desenlerini kullanarak geliştirilmiş ve bir dizi kütüphane ve araçtan faydalanmaktadır.

### Backend

- **Onion Architecture**: Modüler ve katmanlı bir yapı kullanılarak geliştirilmiştir.
- **MediatR Pattern**: İsteklerin işlenmesi için bir mediatör tasarım deseni kullanılmıştır.
- **CQRS Repository Unit of Work Pattern**: Komut ve sorgu sorumluluk ayrımı yapılarak repository ve unit of work desenleri kullanılmıştır.
- **Health Check Eklentisi**: Uygulamanın durumunu izlemek için sağlık kontrolü eklentisi entegre edilmiştir.
- **Serilog**: Yapılandırılabilir ve genişletilebilir bir günlükleme kütüphanesi planlanmıştır.
- **Swagger Dokümantasyonu**: API'nin gelişmiş belgelendirilmesi için Swagger kullanılmıştır.
- **AutoMapper**: Nesne eşlemesi için kullanılan bir kütüphanedir.
- **FluentValidation**: Giriş doğrulaması için kullanılan bir kütüphanedir.

### Frontend

- **Next.js**: React tabanlı web uygulamaları için bir frameworktür.
- **Chakra UI**: React bileşenleri için bir UI kütüphanesidir.
- **Tailwind CSS**: Hızlı ve esnek CSS framework'üdür.
- **Redoc Library**: Swagger JSON'dan beslenen API dokümantasyonu için bir kütüphanedir. Bu kütüphane, API'nin belgelendirilmesi için kullanıcı dostu bir arayüz sağlar.

### Testler

- SpecFlow: Yazılım davranışlarını anlamak ve doğrulamak için kullanılan bir BDD (Behaviour Driven Development) aracıdır.
- Selenium: Web uygulamalarını otomatik olarak test etmek için kullanılan bir araçtır.
- TDD ve BDD Yaklaşımları: Yazılım geliştirme sürecinde Test Driven Development (TDD) ve Behaviour Driven Development (BDD) yaklaşımları kullanılmıştır. Bu yaklaşımlar, yazılımın testlerini öncelikle yazarak ve testlerin başarılı olması için kod geliştirerek yazılımın kalitesini artırmayı hedefler.
