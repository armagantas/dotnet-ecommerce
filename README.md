# E-Commerce Uygulaması

Bu proje, .NET Core 8 kullanılarak geliştirilen bir e-ticaret uygulamasıdır. Farklı API'ler aracılığıyla katalog yönetimi, sipariş işlemleri, sepet yönetimi ve indirim uygulamaları gibi temel işlevselliği sağlar.

## Kullanılan Teknolojiler ve Mimari Yaklaşımlar

### CatalogAPI

- **Mimari Yaklaşım**: CQRS (Command Query Responsibility Segregation) ve Mediator Pattern
- **Veritabanı**: MSSQL

### OrderAPI

- **Mimari Yaklaşım**: Temiz Mimari (Clean Architecture)
- **Katmanlar**: Application, Domain, API ve Infrastructure
- **Veritabanı**: MSSQL

### BasketAPI

- **Mimari Yaklaşım**: N-Katmanlı (NLayer)
- **Veritabanı**: PostgreSQL

### DiscountAPI

- **Mimari Yaklaşım**: N-Katmanlı (NLayer)
- **Protokol**: gRPC
- **Veritabanı**: SQLite

## Kullanım

- **CatalogAPI**: Ürünleri listeleme, ekleme, güncelleme ve silme gibi katalog işlemleri için RESTful endpoint'ler sağlar.
- **OrderAPI**: Sipariş oluşturma, sipariş durumunu sorgulama gibi sipariş işlemleri için RESTful endpoint'ler sağlar.
- **BasketAPI**: Sepet yönetimi için endpoint'ler sağlar, kullanıcılar sepete ürün ekleyebilir, silebilir ve sepetlerini görüntüleyebilirler.
- **DiscountAPI**: Ürünlere indirim uygulama işlemleri için gRPC servisleri sağlar.

## Veritabanları

- **CatalogAPI** ve **OrderAPI** MSSQL veritabanını kullanır.
- **BasketAPI** PostgreSQL veritabanını kullanır.
- **DiscountAPI** SQLite veritabanını kullanır.

## Katkıda Bulunma

Projeye katkıda bulunmak isterseniz, lütfen bir pull request gönderin. Yeni özellikler eklemek veya hata düzeltmeleri yapmak için her zaman açıktır.

## Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Detaylı bilgi için [LICENSE](LICENSE) dosyasına bakabilirsiniz.
