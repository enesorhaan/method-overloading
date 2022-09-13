using System;

namespace metot_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";

            bool sonuc = int.TryParse(sayi,out int outSayi);

            if(sonuc)
            {
                Console.WriteLine("Basarili!");
                Console.WriteLine(outSayi);
            }
            else{
                Console.WriteLine("Basarisiz!");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4, 5, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            //Metot asiri yukleme

            int ifade = 999;
            instance.ekranayazdir(Convert.ToString(ifade));
            instance.ekranayazdir(ifade);
            instance.ekranayazdir("Enes","Orhan");

            //Metot Imzasi
            //metotadi + parametre sayisi + parametre
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a+b;

        }

        public void ekranayazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void ekranayazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void ekranayazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}
