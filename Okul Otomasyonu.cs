
class Ögrenci
{
    static List<Ogrenci> ogrenciler = new List<Ogrenci>();
    static int ogrenciId = 1;
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("OKUL OTOMASYONU");
            Console.WriteLine("1.Öğrenci Ekle");
            Console.WriteLine("2.Öğrencileri Listele");
            Console.WriteLine("3.Not Gir");
            Console.WriteLine("4.Notları Göster");
            Console.WriteLine("0.Çıkış");
            Console.Write("Seçim:");
            string secim = Console.ReadLine();
            switch (secim)
            {
                case "1": OgrenciEkle(); break;
                case "2": OgrenciListele(); break;
                case "3": NotGir(); break;
                case "4": NotlariGoster(); break;
                case "0": return;
                default: Console.WriteLine("Geçersiz seçim"); break;
            }
            Console.WriteLine("Devam etmek için bir tuşa bas");
            Console.ReadKey();
        }
    }
    static void OgrenciEkle()
    {
        Console.Write("Öğrenci Adı Soyadı");
        string ad = Console.ReadLine();
        Ogrenci yeni = new Ogrenci { Id = ogrenciId++, AdSoyad = ad };
        ogrenciler.Add(yeni);
        Console.WriteLine("Öğrenci eklendi");
    }
    static void OgrenciListele()
    {
        Console.WriteLine("Öğrenci Listesi");
        foreach (var o in ogrenciler)
        {
            Console.WriteLine($"ID: {o.Id} - Ad Soyad: {o.AdSoyad}");
        }
    }
    static void NotGir()
    {
        Console.Write("Öğrenci ID");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Hatalı ID");
            return;
        }
        var ogrenci = ogrenciler.Find(o => o.Id == id);
        if (ogrenci == null)
        {
            Console.WriteLine("Öğrenci bulunamadı");
            return;
        }
        Console.Write("Ders Adı");
        string ders = Console.ReadLine();
        Console.Write("Not");
        if (!int.TryParse(Console.ReadLine(), out int not))
        {
            Console.WriteLine("Hatalı not");
            return;
        }
        ogrenci.Notlar[ders] = not;
        Console.WriteLine("Not girildi");
    }
    static void NotlariGoster()
    {
        Console.Write("Öğrenci ID");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Hatalı ID");
            return;
        }
        var ogrenci = ogrenciler.Find(o => o.Id == id);
        if (ogrenci == null)
        {
            Console.WriteLine("Öğrenci bulunamadı");
            return;
        }
        Console.WriteLine($"Ad: {ogrenci.AdSoyad}");
        Console.WriteLine(" Notlar");

        foreach (var not in ogrenci.Notlar)
        {
            Console.WriteLine($"{not.Key}: {not.Value}");
        }
    }
}
class Ögrenci : Ögretmen
{
    static List<ogretmen> ogretmenler = new List<ogretmen>();
    static int ogretmenID = 2;
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Okul Otomasyonu");
            Console.WriteLine("1.Öğretmen Ekle");
            Console.WriteLine("2.Öğretmen Kullanıcı No Gir");
            Console.WriteLine("3.Öğrenciye Not Gir");
            Console.WriteLine("4.Öğrenci Notları Göster");
            Console.WriteLine("5.Notları Kaydet");
            Console.WriteLine("0.Çıkış Yap");
            Console.Write("0.Seçim");
            switch (secim)
            {
                case "1": OgretmenEkle(); break;
                case "2": OgretmenKullaniciNoGir(); break;
                case "3": OgrenciNotGir(); break;
                case "4": OgrenciNotlarıGöster(); break;
                case "5": NotlarıKaydet(); break;
                case "0": return;
                default: Console.WriteLine("Geçersiz seçim"); break;
            }
            Console.WriteLine("Devam etmek için bir tuşa bas");
            Console.ReadKey();
        }
        static void OgretmenEkle()
        {
            Console.Write("Öğretmen Adı Soyadı");
            string ad = Console.ReadLine();
            Ogretmen yeni = new Ogretmen { Id = ogretmenId++, AdSoyad = ad };
            Ogretmenler.Add(yeni);
            Console.WriteLine("Öğretmen Eklendi");
        }
        static void OgretmenKullaniciNoGir()
        {
            Console.Write("Öğretmen Kullanıcı Adı");
            foreach (Ogretmen o in ogretmenler) ;
            Console.WriteLine($"ID: {o.Id} - Ad Soyad: {o.AdSoyad}");
        }
        static void OgrenciNotGir()
        {
            Console.WriteLine("Ogretmen ID");
            if (!int.TryParse(Console.ReadLine(), out int id)) ;
            {
                Console.WriteLine("Hatalı ID");
                return;
            }
            var ogretmen = ogretmenler.Find(o => o.Id == id);
            if (ogretmen == null)
            {
                Console.WriteLine("Öğretmen bulunmadı");
                return;
            }
        }
        Console.Write("Ders Adı");
        string ders = Console.ReadLine();

        Console.Write("Not");
        if (!int.TryParse(Console.ReadLine(), out int not))
        {
            Console.WriteLine("Hatalı not");
            return;
        }
        static void NotlariGoster()
        {
            Console.Write("Öğretmen ID");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Hatalı ID");
                return;
            }
            var ogretmen = ogretmenler.Find(o => o.Id == id);
            if (ogretmen == null)
            {
                Console.WriteLine("Öğretmen bulunamadı");
                return;
            }
            Console.WriteLine($"Ad: {ogretmen.AdSoyad}");
            Console.WriteLine(" Notlar");
            foreach (var not in ogretmen.Notlar)
            {
                Console.WriteLine($"{not.Key}: {not.Value}");
            }
        }
    }
    class Öğrenci : Öğretmen, Müdürlük
    {
        static List<Müdür> Müdürlük = new List<Müdür>();
        static int mudurID = 3;
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Okul Otomasyonu");
                Console.WriteLine("1.Yetkili Ekle");
                Console.WriteLine("2.Müdür Hesabı");
                Console.WriteLine("3.Öğretmen ve Öğrencileri Kontrol Et");
                Console.WriteLine("4.Hataları Bildir");
                Console.WriteLine("0.Çıkış Yap");
                Console.WriteLine("Seçim");
                switch (secim)
                {
                    case "1": YetkiliEkle(); break;
                    case "2": MudurHesabi(); break;
                    case "3": OgretemVeOgrenciKontrolEt(); break;
                    case "4": HatalariBildir(); break;
                    case "0": return;
                    default: Console.WriteLine("Geçersiz Seçenek");
                }
                Console.WriteLine("Devam Etmek İçin bir Tuşa Bas");
                Console.ReadKey();
            }
            static void YetkiliEkle()
            {
                Console.WriteLine("Yetkili Ad Soyad");
                string ad = Console.ReadLine();
                Mudurluk yeni = new Mudurluk(Id = mudurID++, AdSoyad = ad);
                Mudurler.Add(yeni);
                Console.WriteLine("Müdür Eklendi");
            }
            static void MudurHesabi()
            {
                Console.WriteLine("Hesabınıza Girin");
                foreach (Ogretmen o in ogretmenler) ;
                Console.WriteLine($"ID: {o.Id} - Ad Soyad: {o.AdSoyad}");
            }
            static void OgretemVeOgrenciKontrolEt()
            {
                Console.WriteLine("Gerekli Kontrolleri Yap");
                if (!int.TryParse(Console.ReadLine(), out int id))
                {
                    Console.WriteLine("Hatalı ID");
                    return;
                }
                var mudur = mudurler.Find(o => o.Id == id);
                if (mudur == null)
                {
                    Console.WriteLine("Müdür bulunamadı");
                    return;
                }
                Console.Write("Müdür Adı");
                string ders = Console.ReadLine();
                Console.Write("Hata");
                if (!int.TryParse(Console.ReadLine(), out int not))
                {
                    Console.WriteLine("Hatalı not");
                    return;
                }
                mudur.Notlar[ders] = not;
                Console.WriteLine("Not girildi");
            }
        }
    }
}
