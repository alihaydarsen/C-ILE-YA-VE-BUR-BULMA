using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HOŞGELDİNİZ");
            Console.WriteLine("LÜTFEN DOĞUM TARİHİNİZİ GİRİN (ÖRN;01.01.2001 GİBİ)");
            //YAŞ BULMA
            DateTime dogum = Convert.ToDateTime(Console.ReadLine());
            DateTime şimdi = DateTime.Now;
            Console.WriteLine("YAŞINIZ:" + Convert.ToInt32(şimdi.Year-dogum.Year) );
            // BURÇ BULMA 
            if (dogum.Month ==3)
            {
                if (dogum.Day >= 21)
                {
                    Console.WriteLine("BURCUNUZ:KOÇ");
                }
                else
                {
                    Console.WriteLine("BURCUNUZ:BALIK");
                }
            }
            if (dogum.Month == 4)
            {
                if (dogum.Day >= 21)
                {
                    Console.WriteLine("BURCUNUZ:BOĞA");
                }
                else
                {
                    Console.WriteLine("BURCUNUZ:KOÇ");
                }
            }
            if (dogum.Month == 5)
            {
                if (dogum.Day >= 21)
                {
                    Console.WriteLine("BURCUNUZ:İKİZLER");
                }
                else
                {
                    Console.WriteLine("BURCUNUZ:BOĞA");
                }
            }
            if (dogum.Month == 6)
            {
                if (dogum.Day >= 22)
                {
                    Console.WriteLine("BURCUNUZ:YENGEÇ");
                }
                else
                {
                    Console.WriteLine("BURCUNUZ:İKİZLER");
                }
            }
            if (dogum.Month == 7)
            {
                if (dogum.Day >= 23)
                {
                    Console.WriteLine("BURCUNUZ:ASLAN");
                }
                else
                {
                    Console.WriteLine("BURCUNUZ:YENGEÇ");
                }
            }
            if (dogum.Month == 8)
            {
                if (dogum.Day >= 23)
                {
                    Console.WriteLine("BURCUNUZ:BAŞAK");
                }
                else
                {
                    Console.WriteLine("BURCUNUZ:ASLAN");
                }
            }
            if (dogum.Month == 9)
            {
                if (dogum.Day >= 23)
                {
                    Console.WriteLine("BURCUNUZ:TERAZİ");
                }
                else
                {
                    Console.WriteLine("BURCUNUZ:BAŞAK");
                }
            }
            if (dogum.Month == 10)
            {
                if (dogum.Day >= 24)
                {
                    Console.WriteLine("BURCUNUZ:AKREP");
                }
                else
                {
                    Console.WriteLine("BURCUNUZ:TERAZİ");
                }
            }
            if (dogum.Month == 11)
            {
                if (dogum.Day >= 23)
                {
                    Console.WriteLine("BURCUNUZ:YAY");
                }
                else
                {
                    Console.WriteLine("BURCUNUZ:AKREP");
                }
            }
            if (dogum.Month == 12)
            {
                if (dogum.Day >= 22)
                {
                    Console.WriteLine("BURCUNUZ:OĞLAK");
                }
                else
                {
                    Console.WriteLine("BURCUNUZ:YAY");
                }
            }
            if (dogum.Month == 1)
            {
                if (dogum.Day >= 21)
                {
                    Console.WriteLine("BURCUNUZ:KOVA");
                }
                else
                {
                    Console.WriteLine("BURCUNUZ:OĞLAK");
                }
            }
            if (dogum.Month == 2)
            {
                if (dogum.Day >= 19)
                {
                    Console.WriteLine("BURCUNUZ:BALIK");
                }
                else
                {
                    Console.WriteLine("BURCUNUZ:KOVA");
                }
            }

            Console.ReadKey();
        }
    }
}
