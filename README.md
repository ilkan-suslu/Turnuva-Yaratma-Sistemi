# Turnuva-Yaratma-Sistemi (v0.6)
## Önzös
Bu uygulama sadece C#'ı uygulamalı öğrenmek için yaptım. Henüz tamamlanmadı fakat şu an olduğu halini Github'a yükleyerek Github'a da giriş yapmak istedim. 
Readme dosyasını türkçe yazıyorum fakat kodlar ve açıklamaları ingilizce. 
## Özet
Turnuva yaratma uygulaması ile küçük toplulukların kendi içlerinde düzenleyeceği turnuvalar yaratabilirsiniz. Takımlar bir veya daha çok kişiden oluşabilir. Müsabaka eleme sistemi kullanılmakta. Örneğin 8 takım var bu takımlar rastgele 2şerli olarak eşleştirilerek maçlar yapılacak. kaybedeb takım elenecek kazana bir üst rounda çıkacak. Takım sayısı eğer 2,4,8,16... sekansında değilse örneğin 14 takım var o zaman 14 ten büyük en küçük sekans elmanı bulunup (16) aradaki  fark kadar(2) takıma "bye" eşlemesi yapılarak maç yapmadan bir üst rounda çıkacak.  
## Kullandığım Teknolojiler
- Çoklu Windows Form Uygulaması
- SQL Veritabanı
- Text veritabanı(.csv)
- Interface
- Dapper

## Ekranlar
- Turnuva yaratma ekranı (Create Tournament Form)
  - Takım Yaratma Ekranı
    - Takım Elmanı Yaratma Alanı
  - Ödül Yaratma Ekranı
- Turnuva Görüntüleme Ekranı (Yapım Aşamasında)
- Skor Görüntüleme Ekranı (Yapım aşamasında)


## Veri Kayıt Etme
- SQL için yaklaşık 10 ilişkisel tablo ve 20 "Stored Precedure" kullandım.
- Text kaydı için ise  
- Uygulama dosyaları programın seçimine göre Text(.csv)'e ya da SQL Veritabanı'na kayıt edebilir. (SQL de ilişki tablolarını ileride paylaşacağım. Şu an için text kaydı kullanılabilir).
- Text ve SQL kayıt konumu App.config te ayarlanmalıdır.
  - Default Text konumu : C:\data\TournamentTakip
  - Default SQL Server : '.' Local  makine.

