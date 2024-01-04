using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu
{
    public class Hastane
    {
        // Hastane sınıfının özellikleri
        public string Ad { get; set; } // Hastanın adı
        public string Soyad { get; set; } // Hastanın soyadı
        public string Cinsiyet { get; set; } // Hastanın cinsiyeti
        public string TC { get; private set; } // Hastanın TC kimlik numarası

        // Hastane sınıfının yapıcısı
        public Hastane(string ad, string soyad, string cinsiyet, string tc)
        {
            // Yapıcı, bir Hastane nesnesi oluşturulduğunda özelliklere değer atar
            Ad = ad;
            Soyad = soyad;
            Cinsiyet = cinsiyet;
            TC = tc;
        }
    }

    public class HastaneCalisanlari : Hastane
    {
        // Hastane çalışanlarının ek özellikleri
        public string SicilNo { get; private set; } // Çalışanın sicil numarası
        public int EkGosterge { get; set; } // Çalışanın ek göstergesi
        public string CalistigiDepartman { get; set; } // Çalışanın çalıştığı departman

        // HastaneCalisanlari sınıfının yapıcısı
        public HastaneCalisanlari(string ad, string soyad, string cinsiyet, string tc, string sicilNo, int ekGosterge, string calistigiDepartman)
            : base(ad, soyad, cinsiyet, tc) // Hastane sınıfının yapıcısını çağırır
        {
            // Yapıcı, bir HastaneCalisanlari nesnesi oluşturulduğunda özelliklere değer atar
            SicilNo = sicilNo;
            EkGosterge = ekGosterge;
            CalistigiDepartman = calistigiDepartman;
        }

        // Maaş hesaplama metodu
        public virtual int MaasHesapla()
        {
            // Ek göstergeye göre maaşı hesaplar
            if (EkGosterge <= 1500)
                return 15000;
            else if (EkGosterge > 1500 && EkGosterge <= 2200)
                return 20000;
            else if (EkGosterge > 2200 && EkGosterge <= 3000)
                return 30000;
            else if (EkGosterge > 3000 && EkGosterge <= 3600)
                return 40000;
            else
                return 0;
        }
    }

    public class Hasta : Hastane
    {
        // Hastaların ek özellikleri
        public DateTime YatisTarihi { get; set; } // Hastanın yatış tarihi
        public string PoliklinikBilgisi { get; set; } // Hastanın poliklinik bilgisi

        // Hasta sınıfının yapıcısı
        public Hasta(string ad, string soyad, string cinsiyet, string tc, DateTime yatisTarihi, string poliklinikBilgisi)
            : base(ad, soyad, cinsiyet, tc) // Hastane sınıfının yapıcısını çağırır
        {
            // Yapıcı, bir Hasta nesnesi oluşturulduğunda özelliklere değer atar
            YatisTarihi = yatisTarihi;
            PoliklinikBilgisi = poliklinikBilgisi;
        }
    }

    public class Doktor : HastaneCalisanlari
    {
        // Doktorların ek özellikleri
        public string DiplomaNo { get; private set; } // Doktorun diploma numarası
        public string Brans { get; set; } // Doktorun branşı

        // Doktor sınıfının yapıcısı
        public Doktor(string ad, string soyad, string cinsiyet, string tc, string sicilNo, int ekGosterge, string calistigiDepartman, string diplomaNo, string brans)
            : base(ad, soyad, cinsiyet, tc, sicilNo, ekGosterge, calistigiDepartman) // HastaneCalisanlari sınıfının yapıcısını çağırır
        {
            // Yapıcı, bir Doktor nesnesi oluşturulduğunda özelliklere değer atar
            DiplomaNo = diplomaNo;
            Brans = brans;
        }

        // Maaş hesaplama metodu
        public override int MaasHesapla()
        {
            // Ek göstergeye göre maaşı hesaplar
            if (EkGosterge <= 1500)
                return 15000;
            else if (EkGosterge > 1500 && EkGosterge <= 2200)
                return 20000;
            else if (EkGosterge > 2200 && EkGosterge <= 3000)
                return 30000;
            else if (EkGosterge > 3000 && EkGosterge <= 3600)
                return 40000;
            else
                return 0;
        }
    }
}
