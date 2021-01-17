using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Show(Musteri musteri)
        {
                Console.WriteLine("Id : " + musteri.Id);
                Console.WriteLine("Ad : " + musteri.Ad);
                Console.WriteLine("Soyad : " + musteri.Soyad);
                Console.WriteLine("Bakiye : " + musteri.Bakiye);
                Console.WriteLine("********************");
        }
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi, Merhaba " + musteri.Ad);
        }

        public void Update(Musteri musteri)
        {
            Console.WriteLine("Müşteri Güncellendi, " + musteri.Id);
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi, " + musteri.Id);
        }
        
    }
}
