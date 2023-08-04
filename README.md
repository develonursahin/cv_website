# CV_Website

![GitHub](https://img.shields.io/github/license/derinonursahin/cv_website)
![GitHub last commit](https://img.shields.io/github/last-commit/derinonursahin/cv_website)
![GitHub stars](https://img.shields.io/github/stars/derinonursahin/cv_website?style=social)

## Proje Hakkında

Bu proje, ASP .NET Core ve Entity Framework kullanılarak geliştirilmiş bir CV (Curriculum Vitae) web sitesidir. Proje, Data First yaklaşımı ile oluşturulmuş ve temel bir CRUD (Create, Read, Update, Delete) işlevselliği içeren bir yönetici paneli ile entegre edilmiştir.

## Özellikler

- CV Sahibi Bilgileri: Kişisel bilgiler, beceriler, eğitim geçmişi, iş deneyimleri ve projeler gibi CV sahibi ile ilgili detaylı bilgileri ekleyebilir ve güncelleyebilirsiniz.
- Yetenekler: Farklı beceri kategorileri ve bu kategorilere ait beceri bilgilerini yönetebilirsiniz.
- Eğitim Geçmişi: Eğitim aldığınız okulların ve bu okullardaki derslerin bilgilerini girebilirsiniz.
- İş Deneyimleri: Çalıştığınız şirketlerin ve bu şirketlerdeki iş deneyimlerinin detaylarını ekleyebilirsiniz.
- Projeler: Katıldığınız veya geliştirdiğiniz projelerin detaylarını ve teknolojilerini listeleyebilirsiniz.
- Fotoğraflar: CV'nize uygun fotoğrafları yükleyebilir ve yönetebilirsiniz.

## Gereksinimler

- [.NET Core SDK](https://dotnet.microsoft.com/download) - Projenin çalıştırılması için .NET Core SDK'nın yüklü olması gereklidir.
- [Visual Studio Code](https://code.visualstudio.com/) (tercih edilen IDE) veya Visual Studio - Projeyi düzenlemek ve çalıştırmak için bir IDE gereklidir.
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) - Proje veritabanı işlemleri için Entity Framework Core kullanılmıştır.

## Kurulum ve Başlangıç

1. Projeyi bilgisayarınıza klonlayın.
git clone https://github.com/derinonursahin/cv_website.git

2. Proje klasörüne gidin ve aşağıdaki komutu çalıştırın:
dotnet restore

3. Veritabanı yapılandırmasını oluşturmak için aşağıdaki komutları sırasıyla çalıştırın:
dotnet ef migrations add InitialCreate
dotnet ef database update


4. Projeyi çalıştırın ve tarayıcınızda http://localhost:port adresine giderek uygulamayı görüntüleyin.

## Katkılar

- Projeye katkıda bulunmak isterseniz, lütfen Forklayın ve Pull Request gönderin. Sizinle birlikte projeyi geliştirmekten mutluluk duyarız.

## Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Detaylı bilgi için [LICENSE](LICENSE) dosyasına bakınız.

## İletişim

Eğer proje hakkında herhangi bir sorunuz veya öneriniz varsa, lütfen bize ulaşın:

- E-posta: derinonursahin@gmail.com

Linktree: [linktr.ee/derinonursahin](https://linktr.ee/derinonursahin)

---
Burada proje hakkında daha fazla detay, gereksinimler, kurulum talimatları ve iletişim bilgileri ekledik. Bu bilgiler projenizi anlamak ve kullanmak isteyen kişilere yardımcı olacak ve projenizi daha kolay katkı alabilecek bir hale getirecektir. README dosyanızı sürekli güncel tutmayı ve yeni gelişmeleri eklemeyi unutmayın.
