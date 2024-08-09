using System;

namespace while_foreach

{

    class Program 

    {
        static void Main(string []  args)
        {
            // Console.WriteLine("Bir sayı giriniz: ");
            // int sayi = int.Parse(Console.ReadLine());
            // int sayac = 1;
            // int toplam  = 0;
            // while (sayac <= sayi)
            // {
            // toplam += sayac;
            // sayac ++;

            // }
            // Console.WriteLine(toplam/sayi);
            // char karakter = 'a';
            // while(karakter  < 'n')
            // {
            //     Console.Write(karakter);
            //     karakter ++;
            // }

            string[]  arabalar = {"BMW" , "Ford" , "Nisaan","Honda" };
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);

            } 
        }
    }
}