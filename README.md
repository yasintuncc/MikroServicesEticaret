# 🛒 Mikroservis Tabanlı E-Ticaret Projesi

Bu proje, **C# ve .NET** kullanılarak **mikroservis mimarisi** ile geliştirilmiş ölçeklenebilir bir **e-ticaret platformudur**. 
**Sipariş yönetimi, ürün listeleme, kargo işlemleri,  kimlik doğrulama ve ödeme işlemleri** gibi temel e-ticaret işlevlerini içermektedir.

## 🚀 Teknolojiler & Araçlar

- **Backend:** .NET 8, C#
- **Veritabanı:** SQL Server
- **API Gateway:** Ocelot
- **Kimlik Doğrulama:** Identity Server & JWT
- **Servisler Arası İletişim:** RabbitMQ
- **Önbellekleme:** Redis
- **CI/CD:** GitHub Actions

## 📌 Mikroservisler

| Servis Adı        | Açıklama |
|-------------------|----------|
| **API Gateway**  | Servis isteklerini yöneten Ocelot tabanlı ağ geçidi |
| **Auth Service**  | Kimlik doğrulama ve yetkilendirme işlemleri (Identity Server & JWT) |
| **Product Service** | Ürünlerin yönetimi ve listelenmesi |
| **Order Service** | Sipariş oluşturma, güncelleme ve yönetimi |
| **Payment Service** | Ödeme işlemleri |
| **Shipping Service** |	Siparişlerin kargo süreçleri servisi |
| **Notification Service** | RabbitMQ üzerinden bildirim gönderimi |
