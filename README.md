#Araba Üretim Uygulaması
Bu uygulama, bir araba fabrikasında araba üretimini simüle eden basit bir konsol uygulamasıdır. Kullanıcı, araba bilgilerini girerek yeni arabalar oluşturabilir ve bu arabaları bir liste halinde görüntüleyebilir.

Özellikler
Kullanıcıdan araba üretmek isteyip istemediğini sorar.
Kullanıcıdan araba için aşağıdaki bilgileri alır:
Seri Numarası
Marka
Model
Renk
Kapı Sayısı (Sadece 2 veya 4 olarak kabul edilir)
Üretim tarihi otomatik olarak atanır.
Kullanıcı, geçersiz bir kapı sayısı girmesi durumunda uyarılır ve yeniden girmesi istenir.
Kullanıcı, eklenen arabaları liste halinde görüntüleyebilir.
Kurulum
Gerekli Araçlar: C# geliştirme ortamı (örneğin Visual Studio, .NET SDK)
Kodu İndirin: Projeyi yerel makinenize indirin veya kopyalayın.
Proje Dosyası: Proje dosyasını açın ve Program.cs dosyasını düzenleyin.
Uygulamayı Çalıştırın: Terminal veya IDE üzerinden projeyi çalıştırın.
Kullanım
Uygulama başladığında, "Araba üretmek ister misiniz? (E/H):" sorusunu göreceksiniz.
"E" yanıtı vererek yeni bir araba üretmek için sürece başlayın.
Kullanıcıdan alınan bilgiler doğrultusunda yeni bir araba nesnesi oluşturulur.
Araba bilgileri girildikten sonra, kullanıcıya başka bir araba üretmek isteyip istemediği sorulur. "E" derse yeni bir araba oluşturma süreci tekrar başlar.
"H" yanıtı verildiğinde uygulama sonlanır ve üretilen arabaların seri numaraları ve markaları listelenir.
Örnek Kullanım Senaryosu
Uygulama çalıştırıldığında "Araba üretmek ister misiniz? (E/H):" sorusuna "E" yanıtı verin.
Gerekli tüm araba bilgilerini girin.
Başka bir araba üretmek isteyip istemediğinizi belirtin.
Son olarak, "H" yanıtı vererek programı sonlandırın ve üretilen arabaların listesini görüntüleyin.
