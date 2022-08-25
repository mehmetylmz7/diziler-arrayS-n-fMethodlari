using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler_arraySınıfMethodlari
{
    class Program
    {
        static void Main(string[] args)
        {

            // sort 
            // alfebetik veya sıralı bır sekılde sıralamaya yarar.

            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }


            // clear
            //sayiDizisi elemanlarını kullanarak 2. indexten itibaren 2 tane eleman 0'lar

            Array.Clear(sayiDizisi, 2, 2);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }


            // reverse 
            // sort'un tam tersi gorevini yapar elemanları tersten sıralar 

            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }


            // IndexOf
            // girilen degerin kacıncı ındexte oldugunu gosterir

            Console.WriteLine(Array.IndexOf(sayiDizisi,17));


            // resize
            //  yeniden boyutlama yapmaya yarar

            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            
            Console.ReadLine();




        }
    }
}
