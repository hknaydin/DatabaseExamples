# Dükkan Veritabanı Yönetim Sistemi

Bu proje, **KTÜ Of Teknoloji Fakültesi 2024-2025 Yazılım Mühendisliği öğrencileri** için bir eğitim uygulaması olarak geliştirilmiştir. Proje, temel veritabanı yönetim işlemlerini ve C# programlama dili ile veritabanı bağlantısı kurmayı öğretmeyi hedeflemektedir.

---

## Proje Hakkında

**Dükkan Veritabanı Yönetim Sistemi**, bir SQL Server veritabanına bağlanarak farklı tablolardan veri almayı, kullanıcı arayüzü (GUI) üzerinden veritabanı işlemleri gerçekleştirmeyi sağlar. Proje, veritabanı ile çalışmanın temel kavramlarını uygulamalı olarak öğretmek amacıyla hazırlanmıştır.

---

## Kullanılan Teknolojiler ve Araçlar

- **Programlama Dili**: C#
- **Veritabanı Yönetim Sistemi**: SQL Server
- **Kullanıcı Arayüzü**: Windows Forms
- **IDE**: Visual Studio

---

## Veritabanı Yapısı

### Veritabanı: `dukkan`

Projede kullanılan veritabanı, `dukkan` adını taşımaktadır. Veritabanında aşağıdaki tablolar bulunmaktadır:

- **GUIDTest**
  - Numara
  - İsim
- **tbKursiyer**
  - İsim
  - Soyad
  - Telefon
- **tblDoviz**
  - DovizKod
  - DovizAd
  - DovizOran
- **tblEliste**
  - Email
  - IsActive
- **tblEtc**
  - EtcID
  - EtcText
  - EtcNumber
  - Desc
- **tblGorus**
  - GorusKod
  - UrunKod
  - KullaniciKod
  - Baslik
  - Icerik
  - Ip
  - AktifMi
  - Tarih
  - Katilan
  - Katilmayan
- **tblHesap**
  - HesapNo
  - İsim
  - Soyad
  - Şube
  - Bakiye
- **tblIcerik**
  - IcerikKod
  - CatID
  - Title
  - Spot
  - Body
  - ShownDate
  - Statu
  - FrPage
  - DeadLine
  - AdminID
  - Puan
  - Oylama
  - PageView
  - ParentId
  - Rank
  - CtxtLevel

---

## Proje Özellikleri

1. **Veritabanı Bağlantısı**: 
   - SQL Server ile `dukkan` veritabanına bağlanılır.
   - Bağlantı durumu kullanıcıya `Connect` ve `Disconnect` butonları ile kontrol edilir.

2. **Tablo Seçimi ve Görüntüleme**:
   - Veritabanındaki tablolar dinamik olarak alınır ve bir `ComboBox`'ta listelenir.
   - Kullanıcı seçtiği tablonun verilerini bir `DataGridView` üzerinde görüntüleyebilir.
   - Boş tablolar için sütun başlıkları görüntülenir.

3. **Dinamik Veri Yükleme**:
   - Tablolardan alınan veriler, uygun C# model sınıflarına eşlenir ve `DataGridView`'de gösterilir.
   - Her tablo için özel bir veri modeli bulunmaktadır (örneğin: `Kursiyer`, `Doviz`, `GUIDTest`).

4. **Kullanıcı Dostu Arayüz**:
   - Windows Forms üzerinde basit ve anlaşılır bir arayüz ile veritabanı işlemleri gerçekleştirilir.
   - Kullanıcının manuel giriş yapmasını engellemek için `ComboBox` yalnızca seçim modunda çalışır.

---

## Projenin Kullanımı

### Gereksinimler:
- SQL Server kurulu bir bilgisayar
- `dukkan` adında bir veritabanı ve yukarıdaki tablo yapıları
- Visual Studio IDE

### Adımlar:
1. **Proje Kurulumu**:
   - Proje dosyalarını bilgisayarınıza indirin.
   - Visual Studio ile projeyi açın.

2. **Veritabanı Bağlantısı**:
   - `db_connect` değişkenindeki bağlantı dizesini (`Connection String`) kendi SQL Server yapılandırmanıza uygun şekilde düzenleyin:
     ```csharp
     db_connect = new SqlConnection("server=localhost;database=dukkan;integrated security=True");
     ```

3. **Uygulamayı Çalıştırın**:
   - Projeyi çalıştırın ve kullanıcı arayüzü üzerinden `Connect` butonuna tıklayın.
   - Veritabanındaki tabloları `ComboBox` içinde göreceksiniz.
   - Bir tablo seçerek `DataGridView` üzerinde verilerini görüntüleyebilirsiniz.

---

## Geliştiriciler

Bu proje, Karadeniz Teknik Üniversitesi Of Teknoloji Fakültesi 2024-2025 Yazılım Mühendisliği öğrencileri için hazırlanmıştır.

---

## Lisans

Bu proje eğitim amaçlı geliştirilmiştir. Ticari kullanımı sınırlı olabilir ve yalnızca akademik çalışmalar için kullanılabilir.
