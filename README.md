# Kütüphane Takip Uygulaması

Bu uygulama, bir kütüphanenin envanterini ve ödünç işlemlerini takip etmek için tasarlanmıştır.
.NET Core ile yazılmış bir RESTful API, kütüphane envanterini yönetir ve kullanıcı işlemlerini işler.
Next.js ile yazılmış bir web arayüzü, kullanıcılara kütüphane kitaplarını aramak ve ödünç almak için bir arayüz sunar. 
Web arayüzü, .NET Core API'ye istekler yapar ve kullanıcıların etkileşimlerini işler.

Bu proje, çeşitli mimari ve tasarım desenlerini kullanarak modüler ve ölçeklenebilir bir yapıda geliştirilmiştir.

### Mediator ve CQRS Pattern

Proje, Mediator ve CQRS (Command Query Responsibility Segregation) desenlerini kullanarak işlemleri komuta ve sorgulamaya ayırır.
Bu desenler, kodun daha temiz ve bakımı daha kolay hale gelmesini sağlar. Mediator deseni, iletişimi kolaylaştırırken, CQRS deseni, komutları (mutation) ve sorguları (query) ayrı ayrı işleyerek tek sorumluluk prensibini destekler.

### Event Sourcing

Proje, Event Sourcing desenini kullanarak veri değişikliklerini izler ve kaydeder. Bu desen, her değişikliği bir olay olarak kaydederek, veritabanındaki durumu her zaman yeniden oluşturmayı sağlar.
Bu, geçmiş verilerin izlenebilir ve geri alınabilir olmasını sağlar.

### Repository ve Unit of Work

Veritabanı erişimi için Repository tasarım deseni kullanılmıştır. Bu desen, veritabanı işlemlerini soyutlar ve kullanımını kolaylaştırır. Ayrıca, Unit of Work deseni, işlemlerin bir grup içinde toplanmasını ve atomik olarak çalışmasını sağlar.


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


