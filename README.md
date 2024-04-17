# Kütüphane Takip Uygulaması

Bu uygulama, bir kütüphanenin envanterini ve ödünç işlemlerini takip etmek için tasarlanmıştır.
.NET Core ile yazılmış bir RESTful API, kütüphane envanterini yönetir ve kullanıcı işlemlerini işler.
Next.js ile yazılmış bir web arayüzü, kullanıcılara kütüphane kitaplarını aramak ve ödünç almak için bir arayüz sunar. 
Web arayüzü, .NET Core API'ye istekler yapar ve kullanıcıların etkileşimlerini işler.

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
    
      git clone https://github.com/ilyasBozdemir/libraryTrackingApp/tree/case-project

    ```

## Backend Kurulumu

1. Backend klasörüne gidin (`LibraryTrackingApp/src/backend`).
2. Bilgisayarınızda .NET Core SDK ve Visual Studio yüklü olmalıdır.
3. Bağımlılıkları yüklemek için terminalde aşağıdaki komutu çalıştırın:

    ```bash
    dotnet restore
    ```