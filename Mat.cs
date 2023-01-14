namespace FinalHazirlik
{
    public class Mat
    {
        public static int Büyük_Bul(int a, int b) //Verilen iki sayıdan büyük olanı geri döndürür.
        {
            if (a > b)  return a;
            else        return b;
        }
        
        public static int Küçük_Bul(int a, int b) //Verilen iki sayıdan küçük olanı geri döndürür.
        {
            if (a > b) return b;
            else       return a;
        }
        
        public static int Mutlak_Bul (int a)  //Verilen sayının mutlak değerini bulur.
        {
            if (a > 0) return a;
            else       return a * -1;
        }
        
        public static int İşaret_Bul(int a)  //Verilen sayı pozitifse 1, negatifse -1, 0 ise 0 geri döndürür.
        {
            if (a > 0)      return 1;
            else if (a < 0) return -1;
            else            return 0;
        }

        public static int Üs_Bul(int taban, int üs)  //Verilen sayıyı verilen üsle işleme sokup cevabı geri döndürür.
        {
            int sonuç = 1;
            for (int i = 0; i < üs; i++)
            {
                //sonuç = sonuç * taban;
                sonuç *= taban;
            }
            return sonuç;
        }
        
        public static int Kök_Bul(int sayı)  //Verilen tam kare sayının kare kökünü bulur.
        {
            int kök = 1;

            for (int i = 0; i < sayı; i++)
            {
                if (i * i == sayı)
                {
                    kök = i;
                    break;
                }
            }
            return kök;
        }
    }
}