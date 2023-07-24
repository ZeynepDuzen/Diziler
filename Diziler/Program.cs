using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** string degiskenler ile dizi kullanımı ***
            string[] sehirler = { "Edirne", "Bursa", "İstanbul", "Tekirdağ" };
            //Console.WriteLine("Sehiler dizisinin 3. index değeri : " + sehirler[3]);
            //Console.WriteLine(sehirler[0]);
            //Console.WriteLine(sehirler[1]);
            //Console.WriteLine(sehirler[2]);
            //Console.WriteLine(sehirler[3]);

            //int i;
            //for (i = 0; i < 4; i++)
            //{
            //    Console.WriteLine(sehirler[i]);
            //}




            // ***int degiskenler ile dizi kullanimi ***
            int[] sayilar = { 10, 20, 30, 40, 50 };
            Console.WriteLine(sayilar[2]);

            int i;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(sayilar[i]);
            }


            Console.Read();
        }
    }
}
