using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_da_Tek_Çift_Sayi_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("Bir sayı giriniz?");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 2 == 0 && sayi > 0)
            {
                Console.Write("Sayı pozitif çift sayıdır.");
            }
            else if (sayi % 2 == 0 && sayi < 0)
            {
                Console.Write("Sayı negatif çift sayıdır.");
            }
            else if (sayi % 2 != 0 && sayi > 0)
            {
                Console.Write("Sayı pozitif tek sayıdır.");
            }
            else if (sayi % 2 != 0 && sayi < 0)
            {
                Console.Write("Sayı negatif tek sayıdır.");
            }
            else if ( sayi == 0) 
            {
                Console.Write("Sayı ne negatif nede pozitif bir sayıdır.");
            }
            Console.ReadKey();
        }
    }
}
