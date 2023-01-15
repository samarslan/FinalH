using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalHazirlik
{
    public class Yazi
    {
        public static int Uzunluk_Bul(string kelime)             //kelime uzunluğunu bulan fonksiyon
        {
            int uzunluk = 0;
            foreach (char harf in kelime)
            {
                uzunluk++;
            }
            return uzunluk;
        }
        
        public static int Uzunluk_Bul_2(string[] metin)          //dizideki eleman sayısını bulan fonksiyon
        {
            int uzunluk = 0;
            foreach (string kelime in metin)
            {
                uzunluk++;
            }
            return uzunluk;
        }
        
        public static string[] Ayirma(string metin, char karakter)    //metni ayıran fonksiyon String.Split() karşılığı
        {
            int uzunluk = Uzunluk_Bul(metin);
            int kelime_sayisi = 0;
            for (int i = 0; i < uzunluk; i++)
            {
                if (metin[i] == karakter)
                {
                    kelime_sayisi++;
                }
            }
            string[] kelime = new string[kelime_sayisi + 1];
            int kelime_no = 0;
            string kelime_olustur = "";
            for (int i = 0; i < uzunluk; i++)
            {
                if (metin[i] != karakter)
                {
                    kelime_olustur += metin[i];
                }
                else
                {
                    kelime[kelime_no] = kelime_olustur;
                    kelime_no++;
                    kelime_olustur = "";
                }
            }
            kelime[kelime_no] = kelime_olustur;
            return kelime;
        }
        
        public static string Birlestir(string[] dizi, char karakter)    //diziyi birleştiren fonksiyon String.Join() karşılığı
        {    
            int uzunluk = Uzunluk_Bul_2(dizi);
            string metin = "";
            for (int i = 0; i < uzunluk; i++)
            {
                metin += dizi[i];
                if (i != uzunluk - 1)
                {
                    metin += karakter;
                }
            }
            return metin;
        }
        
        public static string SonunaEkleme(string metin, string ek)    //metnin sonuna ek ekleyen fonksiyon
        {
            int uzunluk = Uzunluk_Bul(metin);
            string metin_olustur = metin;
            metin_olustur += ek;
            return metin_olustur;
        }
        
        public static string BasinaEkleme(string metin, string ek)    //metnin başına ekleme ekleyen fonksiyon
        {
            string metin_olustur = "";
            metin_olustur += ek;
            metin_olustur += metin;
            return metin_olustur;
        }
        
        public static string BasaBoslukEkle(string metin, int toplam)    //metnin başına boşluk ekleyen fonksiyon
        {
            int uzunluk = Uzunluk_Bul(metin);
            string metin_olustur = "";
            int bosluk_sayisi= toplam - uzunluk;
            for (int i = 0; i < bosluk_sayisi; i++)
            {
                metin_olustur += " ";
            }
            metin_olustur += metin;
            return metin_olustur;
        }
        
        public static string SonaBoslukEkle(string metin, int toplam)   //metnin sonuna boşluk ekleyen fonksiyon
        {
            int uzunluk = Uzunluk_Bul(metin);
            string metin_olustur = metin;
            int bosluk_sayisi= toplam - uzunluk;
            for (int i = 0; i < bosluk_sayisi; i++)
            {
                metin_olustur += " ";
            }
            return metin_olustur;
        }
        
        public static string Degistir(string metin, string eski,string yeni)   //metindeki eskiyi yeni ile değiştiren fonksiyon
        {
            int uzunluk = Uzunluk_Bul(metin);
            char[] metin_olustur = metin.ToCharArray();
            int pos = Indexini_bul(metin, eski);
            int harf = 0;
            for (int i = 0; i < uzunluk; i++)
            {
                if(harf>=eski.Length)
                {
                    break;
                }
                if (i == pos)
                {
                    metin_olustur[i] = yeni[harf];
                    harf++;
                    pos++;
                }
            }
            return new string(metin_olustur);
        }
        public static string BastanBoslukSil(string metin)      //metnin başındaki boşlukları silen fonksiyon
        {
            int uzunluk = Uzunluk_Bul(metin);
            string metin_olustur = "";
            int bosluk_sayisi = 0;
            for (int i = 0; i < uzunluk; i++)
            {
                if (metin[i] == ' ')
                {
                    bosluk_sayisi++;
                }
                else
                {
                    break;
                }
            }
            for (int i = bosluk_sayisi; i < uzunluk; i++)
            {
                metin_olustur += metin[i];
            }
            return metin_olustur;
        }
        
        public static string SondanBoslukSil(string metin)      //metnin sonundkai boşlukları silen fonksiyon
        {
            int uzunluk = Uzunluk_Bul(metin);
            string metin_olustur = "";
            int bosluk_sayisi = 0;
            for (int i = uzunluk - 1; i >= 0; i--)
            {
                if (metin[i] == ' ')
                {
                    bosluk_sayisi++;
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i < uzunluk - bosluk_sayisi; i++)
            {
                metin_olustur += metin[i];
            }
            return metin_olustur;
        }

        public static string BoslukSil(string metin) //Baştan ve sondan boşlukları silen fonksiyon
        {
            string metin_olustur = metin;
            metin_olustur = BastanBoslukSil(metin_olustur);
            metin_olustur = SondanBoslukSil(metin_olustur);
            return metin_olustur;
        }
        
        public static int Indexini_bul(string metin, string kisim)  //Verilen kismin metindeki indexini bulan fonksiyon
        {
            char[] metinArr = metin.ToCharArray();
            int sayi = 0;
            int index = 0;
            bool varmi = false;
            for (int i = 0; i < Uzunluk_Bul(metin); i++)
            {
                if (sayi == Uzunluk_Bul(kisim))
                {
                    break;
                }
                if (metinArr[i] == kisim[sayi])
                {
                    sayi++;
                    if (varmi == false)
                    {
                        index = i;
                        varmi = true;
                    }
                }
                else
                {
                    index = 0;
                    varmi = false;
                }
            }
            return index;
        } 
        
        public static int[] Bul(string metin, char karakter)      //verilen karakterin metinde konumu bulup geri döndüren fonksyon
        {
            int uzunluk = Uzunluk_Bul(metin);
            int konum_sayisi = 0;
            for (int i = 0; i < uzunluk; i++)
            {
                if (metin[i]==karakter)
                {
                    konum_sayisi++;
                }
            }
            int k = 0;
            int[] konumlar = new int[konum_sayisi];
            for (int i = 0; i < uzunluk; i++)
            {
                if (metin[i]==karakter)
                {
                    konumlar[k] = i;
                    k++;
                }
            }

            return konumlar;
        }
        
        public static string Kaldir(string metin, int index, int range)  //verilen indexden başlayarak range kadar karakteri silen fonksiyon
        {
            int uzunluk = Uzunluk_Bul(metin);
            string metin_olustur = "";
            for (int i = 0; i < uzunluk; i++)
            {
                if (i>=index && i<index+range)
                {
                    continue;
                }
                metin_olustur += metin[i];
            }
            return metin_olustur;
        }
        
        public static string Buyut(string metin)  //metni büyük harfe çeviren fonksiyon
        {
            int uzunluk = Uzunluk_Bul(metin);
            string metin_olustur = "";
            for (int i = 0; i < uzunluk; i++)
            {
                metin_olustur += Convert.ToChar(Convert.ToInt32(metin[i]) - 32);
            }
            return metin_olustur;
        }
        
        public static string Kucult(string metin)  //metni küçük harfe çeviren fonksiyon
        {
            int uzunluk = Uzunluk_Bul(metin);
            string metin_olustur = "";
            for (int i = 0; i < uzunluk; i++)
            {
                metin_olustur += Convert.ToChar(Convert.ToInt32(metin[i]) + 32);
            }
            return metin_olustur;
        }
    }
}
