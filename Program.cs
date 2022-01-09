using System;

namespace Array_Sınıfı
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort Methodu
            int [] sayiDizisi = {23,12,4,86,72,3,11,17};
            System.Console.WriteLine("** Sırasız Dizi **");
            foreach (var item in sayiDizisi)
            {
               System.Console.WriteLine(item); 
            }
            System.Console.WriteLine("** Sıralı Dizi **");
            Array.Sort(sayiDizisi);
            foreach(var x in sayiDizisi)
                System.Console.WriteLine(x);
            
            //Clear Methodu 
  //(Dizinin içerisinde elemanların 2.parametrede verilen indexten başlar 3.parametredeki kadar indexi -elemanı 0 olarak döndürür)

            System.Console.WriteLine("** Array Clear **");
            Array.Clear(sayiDizisi,2,2);
            foreach(var x in sayiDizisi)
                System.Console.WriteLine(x);

            //Reverse Methodu -- Diziyi Aynalama Yöntemi ile Tersten Döndürür.
            System.Console.WriteLine("** Array Reverse **");
            Array.Reverse(sayiDizisi);

            foreach (var item in sayiDizisi)
            {
                System.Console.WriteLine(item);
            }

            //IndexOf Methodu
            System.Console.WriteLine("** Array IndexOf **");
           System.Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            //Resize Methodu
             System.Console.WriteLine("** Array Resize **");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]=99;
            foreach (var item in sayiDizisi)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}
