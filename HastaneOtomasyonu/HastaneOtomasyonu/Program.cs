using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu

{

    class Program
    {
        static void Main(string[] args)
        {
            //Yorum satırlarında programın daha okunulabilir olması için GPT'ye başvurdum.
            // Hasta nesnesi oluşturuluyor
            Hasta hasta = new Hasta("Ayşe", "Yılmaz", "Kadın", "12345678910", new DateTime(2023, 11, 30), "Kardiyoloji");

            // Hastane çalışanı nesnesi oluşturuluyor
            HastaneCalisanlari calisan = new HastaneCalisanlari("Mehmet", "Nakkaş", "Erkek", "10987654321", "101", 1500, "Acil Servis");

            // Doktor nesnesi oluşturuluyor
            Doktor doktor = new Doktor("Ahmet", "Öztürk", "Erkek", "11223344556", "201", 2000, "Nefroloji", "301", "Nefroloji");

            // Hasta bilgileri ekrana yazdırılıyor
            Console.WriteLine("Hasta Bilgileri:");
            Console.WriteLine($"Hasta: {hasta.Ad} {hasta.Soyad}, Poliklinik Bilgisi: {hasta.PoliklinikBilgisi}, Yatış Tarihi: {hasta.YatisTarihi.ToString("yyyy-MM-dd")}");

            // Hastane çalışanı bilgileri ekrana yazdırılıyor
            Console.WriteLine("Hastane Çalışanı Bilgileri:");
            Console.WriteLine($"Hastane Çalışanı: {calisan.Ad} {calisan.Soyad}, Sicil No: {calisan.SicilNo}, Çalıştığı Departman: {calisan.CalistigiDepartman}");
            Console.WriteLine($"Maaş: {calisan.MaasHesapla()}.0 TL"); // Maaş hesaplama metodu çağrılıyor

            // Doktor bilgileri ekrana yazdırılıyor
            Console.WriteLine("Doktor Bilgileri:");
            Console.WriteLine($"Hastane Çalışanı: Dr. {doktor.Ad} {doktor.Soyad}, Sicil No: {doktor.SicilNo}, Çalıştığı Departman: {doktor.CalistigiDepartman}");
            Console.WriteLine($"Maaş: {doktor.MaasHesapla()}.0 TL"); // Maaş hesaplama metodu çağrılıyor

            Console.ReadKey(); // Kullanıcının bir tuşa basmasını bekliyor
        }
    }
}
