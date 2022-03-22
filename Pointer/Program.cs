using System;
using System.Collections.Generic;

namespace Pointer
{
     class Program
    {
        unsafe static void Main(string[] args)
        {
            /* POİNTER KULLANIMI */

            List<int> dizi = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            dizi.Insert(3, 100);
         
            fixed (int* ptr = dizi.ToArray())                                                                       
            {

                for (int i = 0; i < dizi.ToArray().Length; i++)
                {
                    uint z = (uint)(ptr + i);
                    /*
                     adresi döndürürken uint türüne dönüştürdük bunun nedeni uint büyüklüğünün bir adresi tutabilecek en küçük boyuttaki
                     veri tipidir, daha büyük kapasiteli bir veri tipide kullanılabilir.
                    */
                    Console.WriteLine(*(ptr + i) + " Adresi :" + z.ToString("X"));
                }
            }
            /*
             Garbage Collector mekanizması nesnelerin program çalıştığı sürece veya ömrü bitmiş ise bellek durumunu her an değiştirebilir.
             Dolayısıyla sınıf nesneleri üzerinde erişilen öğelerin aynı adresi taşıma ihtimali bu yüzden ortadan kalkar. 
             Ama bizim bu işlemi fixed bloğu ile önleme şansımız vardır.
             */

            Console.WriteLine("*---------------------------*");
            Console.WriteLine("*---------------------------*");

            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }

    }
}
/*
 
 */