CokluDilCeviri
Bu proje, C# dili ve Visual Studio'da geliştirilmiş, metinleri farklı diller arasında çevirmeyi amaçlayan basit bir uygulamadır.

📜 Hakkında
CokluDilCeviri uygulaması, kullanıcıdan alınan metni belirlenen kaynak dilden hedef dile çevirmek üzere tasarlanmıştır. Bu proje, harici bir çeviri hizmeti (örneğin Google Translate API, Microsoft Translator API vb.) ile entegrasyonu göstermektedir.

✨ Özellikler
Metin Girişi: Kullanıcıların çevrilecek metni girebileceği bir alan.

Dil Seçimi: Kaynak ve hedef dillerin seçilebileceği açılır listeler (ComboBox).

Çeviri İşlemi: Seçilen API üzerinden metni çevirme ve sonucu görüntüleme.

Hata Yönetimi: API erişim hataları veya boş giriş durumları için kullanıcıya geri bildirim sağlama.

(Bu özellikler, çeviri projenizin tipik yapısına dayanarak varsayılmıştır.)

⚙️ Gereksinimler

Visual Studio (Sürüm 17.14.36518.9 d17.14 veya üzeri) 

.NET Framework/Core geliştirme iş yükü.

API Anahtarı (Key): Projenin çalışması için kullanılan çeviri servisine ait geçerli bir API anahtarı gereklidir.
🚀 Kurulum ve Çalıştırma
Projeyi Klonlayın:
git clone [https://github.com/zehradagasann/CokluDilCeviri]
Visual Studio'da CokluDilCeviri.sln dosyasını açın.

API Anahtarını Yapılandırın: Projede API anahtarının kullanıldığı yerde (genellikle bir ayarlar dosyası veya doğrudan kod içinde), geçerli anahtarınızı ekleyin.

Projeyi derleyin ve F5 tuşuna basarak uygulamayı başlatın.
Ekran Görüntüleri
Uygulamanın nasıl göründüğünü göstermek için buraya ekran görüntüleri ekleyin.
<img width="755" height="351" alt="image" src="https://github.com/user-attachments/assets/6ae187c9-1aa8-4034-ac43-54cb5e7d9a2b" />
<img width="932" height="543" alt="image" src="https://github.com/user-attachments/assets/371051d0-56c2-4a64-9716-eee76f934da1" />
<img width="900" height="550" alt="image" src="https://github.com/user-attachments/assets/c727dfdc-2fe2-4aee-9ac1-5430f5d9e1b7" />
📂 Önemli Dosyalar
CokluDilCeviri.csproj: Proje ayarlarını içerir.

Form1.cs: Kullanıcı arayüzü olaylarını ve çeviri mantığını yöneten ana C# kod dosyası.

Form1.Designer.cs: UI bileşenlerinin (TextBox, Button, ComboBox, vb.) tanımlarını içerir.


