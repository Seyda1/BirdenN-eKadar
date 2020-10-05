using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("bir a sayısı giriniz");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("toplam={0}", topla(a));
             kare_bul(a);

            Console.ReadLine();
        }
        static int  topla(int a)
        {
            int i,toplam=0;
         for (i = 0; i <= a; i++)
            {
                toplam = i + toplam;
                
             }
            return toplam;
        }
        static void kare_bul(int a)
        {
            int kare = 0, i;
            for(i=0;i<=a;i++)
            {
                kare = i * i;
                Console.WriteLine("{0} sayısının karesi={1}", i, kare);
            }
        
        }
    }
}
