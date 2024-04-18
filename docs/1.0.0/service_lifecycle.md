# Hizmet Yaşam Döngüleri

Bu belge, ASP.NET Core veya .NET Core projelerinde kullanılan hizmetlerin yaşam döngülerini açıklar. Hizmetlerin yaşam döngüsü, hizmet örneklerinin nasıl oluşturulduğunu ve paylaşıldığını belirler.

## `AddSingleton`

- `AddSingleton`, hizmetin yalnızca bir örneğini oluşturur ve uygulama boyunca aynı örneği paylaşır.
- İlk kez çağrıldığında hizmeti oluşturur ve bu örneği daha sonra tekrar kullanır.
- Singleton hizmetler, uygulama ömrü boyunca aynı örneğin kullanılması gereken durumlar için uygundur.

Örnek kullanımı:

```csharp
services.AddSingleton<MyService>();
```

## `AddScoped`

- `AddScoped`, her HTTP isteği için yeni bir hizmet örneği oluşturur ve bu isteğin ömrü boyunca aynı örneği kullanır.

- Her HTTP isteği bir "kapsam" (scope) oluşturur ve bu kapsam içinde hizmetler paylaşılır.
- Scoped hizmetler, web uygulamaları için kullanışlıdır, çünkü her istemci isteği için ayrı hizmet örnekleri gerekebilir.

Örnek kullanımı:

```csharp
services.AddScoped<MyService>();
```

## `AddTransient`

- ``AddTransient``, her çağrı veya her istemci isteği için yeni bir hizmet örneği oluşturur.
- Hizmetin yaşam döngüsü, her çağrı veya her istemci isteği için yeni bir örneğin oluşturulmasını gerektiren hızlı geçici hizmetler için uygundur.
- Her isteğe veya çağrıya yeni bir hizmet örneği sağlar.

```csharp
services.AddTransient<MyService>();
```




