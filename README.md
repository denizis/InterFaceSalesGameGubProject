


![GamehubPicture](https://github.com/user-attachments/assets/1a281a13-9561-436e-9dfe-f5771e450fe4)



Game Sales System

This project is a C#-based application that simulates a game sales system.
The application includes core functionalities such as adding players, adding games, managing campaigns, and handling game sales. 
Additionally, it connects to a service to validate players' national identification numbers (TcNo).

Features
Player Management: Add player details (name, surname, national ID, birth year) and send them to a validation service.
Game Management: Add games with information like product name, price, description, and category.
Campaign Management: Create discount campaigns and apply them during game sales.
Sales System: Perform game purchases by applying active campaigns for players.

Technologies Used
C#: Programming language used for development.
.NET Core: Development framework.
Service Adapter: An interface adapter used for player TcNo verification with an external service.

Project Structure
Player: Player class, holds player information and performs validation.
Product: Game class, holds game information.
Campaign: Campaign class, manages discount and campaign details.
SalesPageManager: Handles the game sales process.
ServiceAdapter: Connects to the external service for player verification.

TR

Oyun Satış Sistemi
Bu proje, bir oyun satış simülasyonunu içeren C# tabanlı bir uygulamadır. 
Uygulama, oyuncu ekleme, oyun ekleme, kampanya yönetimi ve oyun satışını kapsayan temel işlevleri içerir. 
Ayrıca, oyuncuların TC kimlik numaralarının doğrulanması için bir servise bağlanmaktadır.

Özellikler
Oyuncu Ekleme: Oyuncu bilgilerini (ad, soyad, TC kimlik numarası, doğum yılı) ekleyin ve doğrulama servisine gönderir.
Oyun Ekleme: Ürün adı, fiyatı, açıklaması ve kategorisi gibi bilgilerle oyun ekleyin.
Kampanya Yönetimi: İndirim kampanyalarını ekleyin ve oyun satışlarında bu kampanyaları uygulayın.
Satış Sistemi: Oyuncuların oyun satın alması sırasında kampanyalar uygulayarak satış işlemi gerçekleştirin.

Kullanılan Teknolojiler
C#: Uygulamanın geliştirilmesinde kullanılan dil.
.NET Core: Uygulama geliştirme framework'ü.
Servis Adapter: Oyuncuların TC kimlik numarasını doğrulamak için kullanılan bir arayüz adaptörü.


Proje Yapısı
Player: Oyuncu sınıfı, oyuncunun bilgilerini tutar ve doğrulama işlemi yapılır.
Product: Oyun sınıfı, oyun bilgilerini içerir.
Campaign: Kampanya sınıfı, indirim ve kampanya bilgilerini tutar.
SalesPageManager: Satış işlemini gerçekleştiren sınıf.
ServiceAdapter: Oyuncu doğrulaması için kullanılan harici hizmete bağlanır.// Tc no kontrol 





