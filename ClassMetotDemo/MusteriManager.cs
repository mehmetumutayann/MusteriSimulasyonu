using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo

   
{
    internal class MusteriManager
    {


        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Isim + "adlı müşteri başarıyla eklendi.");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Isim + "adlı müşteri başarıyla silindi.");
        }

        public void Kisisel(Musteri musteri)
        {
            Console.WriteLine("Müşteri Kişisel Bilgileri");       
            Console.WriteLine("Ad: "+musteri.Isim);       
            Console.WriteLine("Soyad: "+musteri.Soyisim);       
            Console.WriteLine("Id: "+musteri.Id);
            Console.WriteLine("Şehir: "+musteri.Sehir);
        }

    
    }
}
