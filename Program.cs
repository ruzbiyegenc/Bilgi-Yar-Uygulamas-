using System;

namespace bilgi_yarışması
{
    class Program
    {
        static void Main(string[] args) //Ana fonksiyonumuzu oluşturduk 
        {
            int sayac = 0;
            string isim;
            Console.WriteLine("Lutfen İsminizi Yaziniz:"); // Yarışmacımızın ismini ekrana yazdırmak istiyoruz.
            isim = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Merhaba " + isim + " Bilgi yarışmasına Hosgeldin");
            Console.WriteLine("Yarışma 10 sorudan oluşmakta olup her sorunun doğru cevabı 10 puandır, Başarılar dilerim.");//Genel bilgilendirme yapıyoruz.
            Console.WriteLine("LUTFEN CEVAPLANDİRMAYİ  A,B,C VE D ŞEKLİNDE YAPİNİZ");

            String cevap;
            string A, B, C, D;
            int puan = 0; 

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hazir misiniz?  işte ilk soru!!!"); 

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1- Fatih Sultan Mehmet'in Babası kimdir? "); //ilk soru
            Console.WriteLine("A-2.Murat\nB-Yildirim Beyazit\nC-1.Mehmet\nD-4.Osman");
            cevap = Console.ReadLine();

            if (cevap == "A") //if else yapılarını kullanacağız.
            {


                Console.WriteLine("TEBRİKLER!!!! Doğru cevap, 10 puan kazandiniz 2. soruya geçiniz...");
                sayac++; //her doğru cevap için sayaç 1 artacak 
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Yanlış cevap verdiniz,2. soruya geçiniz.."); //yanlış cevap verildiğinde programdan çıkış olmadan diğer soruya geçilecek
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("2-Hangisi Periyodik Tabloda Bulunan Bir Eleman Degildir? \nA-Azot\nB-Su\nC-Oksijen\nD-Karbon");
            cevap = Console.ReadLine();

            if (cevap == "B")
            {

                Console.WriteLine("TEBRİKLER!!!! Doğru cevap, 10 puan kazandiniz 3. soruya geçiniz...");
                sayac++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Yanlış cevap verdiniz,3. soruya geçiniz..");

            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("3-Hangi Hayvan Memeli Değildir? \nA-Yarasa\nB-İnek\nC-Balina\nD-Penguen");
            cevap = Console.ReadLine();


            if (cevap == "D")
            {

                Console.WriteLine("TEBRİKLER!!!! Doğru cevap, 10 puan kazandiniz 4. soruya geçiniz...");
                sayac++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Yanlış cevap verdiniz,4. soruya geçiniz..");

            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("4-Hangisi kuvvet birimidir? \nA-Joule\nB-Coulomb\nC-Newton\nD-Pascal");
            cevap = Console.ReadLine();

            if (cevap == "C")
            {

                Console.WriteLine("TEBRİKLER!!!! Doğru cevap, 10 puan kazandiniz 5. soruya geçiniz...");
                sayac++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Yanlış cevap verdiniz,5. soruya geçiniz..");

            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("5-Kuyucaklı Yusuf adlı eser kime aittir? \nA-Yaşar Kemal\nB-Sabahattin Ali\nC-Yusuf Atılgan\nD-Namık Kemal");
            cevap = Console.ReadLine();

            if (cevap == "B")
            {

                Console.WriteLine("TEBRİKLER!!!! Doğru cevap, 10 puan kazandiniz 6. soruya geçiniz...");
                sayac++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Yanlış cevap verdiniz, 6. soruya geçiniz..");

            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("6-Aşağıda Verilen İlk Çağ Uygarlıklarından Hangisi Yazıyı İcat Etmiştir? \nA-Uygurlar\nB-Hititler\nC-Elamlar\nD-Sümerler");
            cevap = Console.ReadLine();

            if (cevap == "D")
            {

                Console.WriteLine("TEBRİKLER!!!! Doğru cevap, 10 puan kazandiniz 7. soruya geçiniz...");
                sayac++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Yanlış cevap verdiniz, 7. soruya geçiniz..");

            }


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("7-Aşağıdakilerden Hangisi Dünya Sağlık Örgütünün Kısaltılmış İsmidir? \nA-Uhw\nB-Unıcef\nC-Who\nD-Nato");
            cevap = Console.ReadLine();

            if (cevap == "C")
            {

                Console.WriteLine("TEBRİKLER!!!! Doğru cevap, 10 puan kazandiniz 8. soruya geçiniz...");
                sayac++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Yanlış cevap verdiniz, 8. soruya geçiniz..");

            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("8-Aspirinin Hammaddesi Nedir? \nA-Söğüt\nB-Köknar\nC-Kavak\nD-Meşe");
            cevap = Console.ReadLine();

            if (cevap == "A")
            {

                Console.WriteLine("TEBRİKLER!!!! Doğru cevap, 10 puan kazandiniz 9. soruya geçiniz...");
                sayac++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Yanlış cevap verdiniz, 9. soruya geçiniz..");

            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("9-Üç Büyük Dince Kutsal Sayılan Şehir Hangisidir? \nA-Mekke\nB-Kudüs\nC)Roma\nD)İstanbul");
            cevap = Console.ReadLine();

            if (cevap == "B")
            {

                Console.WriteLine("TEBRİKLER!!!! Doğru cevap, 10 puan kazandiniz son soruya geçiniz...");
                sayac++;
            }
            else
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Yanlış cevap verdiniz, son soruya geçiniz..");

            }



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("10-Mustafa Kemal Atatürk’ün Nüfusa Kayıtlı Olduğu İl Hangisidir? \nA-Bursa\nB)Ankara\nC)İstanbul\nD)Gaziantep");
            cevap = Console.ReadLine();

            if (cevap == "D")
            {


                sayac++;

                Console.WriteLine("TEBRİKLER!!!!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Yanlış cevap verdiniz");

            }

            puan = sayac * 10; //her doğru cevapta artan sayaç 10 ile çarpılır ve puan hesaplanır
            Console.WriteLine("Toplam Puanınız: {0}", puan);
            Console.ReadLine(); 

        }
    }
}


