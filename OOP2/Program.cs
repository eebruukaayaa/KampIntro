// See https://aka.ms/new-console-template for more information



using OOP2;

//Ebru Kaya
GercekMusteri musteri1 = new GercekMusteri();
musteri1.Id = 1;
musteri1.MusteriNo = "12345";
musteri1.Adi = "Ebru";
musteri1.Soyadi = "Kaya";
musteri1.TcNo = "12345689123";

//Kodlama.io
TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.Id = 2;
musteri2.MusteriNo = "54321";
musteri2.SirketAdi = "Kodlama.io";
musteri2.VergiNo = "123456890";


//Gerçek Müşteri - Tüzel Müşteri
//SOLID


Musteri musteri3 = new GercekMusteri();
Musteri musteri4 = new TuzelMusteri();


CustomerManager musteriManeger = new CustomerManager();
musteriManeger.Add(musteri1);
musteriManeger.Add(musteri2);