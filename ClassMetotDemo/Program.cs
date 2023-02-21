using ClassMetotDemo;

Musteri musteri = new Musteri();


Musteri musteri1= new Musteri();
musteri1.Id = 198;
musteri1.Isim = "Mehmet Umut";
musteri1.Soyisim = "Ayan";
musteri1.Sehir = "Istanbul";

Musteri musteri2 = new Musteri();
musteri2.Id = 19238;
musteri2.Isim = "Ecrin";
musteri2.Soyisim = "Ayan";
musteri2.Sehir = "Istanbul";

Musteri musteri3 = new Musteri();
musteri3.Id = 1854328;
musteri3.Isim = "Hamza";
musteri3.Soyisim = "Ayan";
musteri3.Sehir = "Istanbul";


MusteriManager musteriManager = new MusteriManager();

//musteriManager.Ekle(musteri1);
musteriManager.Kisisel(musteri2);




