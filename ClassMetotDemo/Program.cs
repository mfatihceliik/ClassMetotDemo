using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Muhammed Fatih";
            musteri1.Soyad = "Çelik";
            musteri1.Bakiye = 5000;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Engin";
            musteri2.Soyad = "Demiroğ";
            musteri2.Bakiye = 8000;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Nejla";
            musteri3.Soyad = "Çelik";
            musteri3.Bakiye = 4750;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Ad = "Erkan";
            musteri4.Soyad = "Çelik";
            musteri4.Bakiye = 6000;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Show(musteri1);
            musteriManager.Show(musteri2);
            musteriManager.Show(musteri3);
            musteriManager.Show(musteri4);

            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);

            musteriManager.Update(musteri1);
            musteriManager.Update(musteri2);
            musteriManager.Update(musteri3);
            musteriManager.Update(musteri4);

            musteriManager.Delete(musteri1);
            musteriManager.Delete(musteri2);
            musteriManager.Delete(musteri3);
            musteriManager.Delete(musteri4);
        }
    }
}
