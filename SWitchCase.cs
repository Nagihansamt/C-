using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ay = DateTime.Now.Month;

            switch (ay)
            {
                case 1:
                    Console.WriteLine("Ocak");
                    break;
                case 2:
                    Console.WriteLine("Şubat");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Nİsan");
                    break;
                case 5:
                    Console.WriteLine("Mayıs");
                    break;
                case 6:
                    Console.WriteLine("Haziran");
                    break;
                case 7:
                    Console.WriteLine("Temmuz");
                    break;
                case8:
                    Console.WriteLine("Ağustos");
                case 9:
                    Console.WriteLine("Eylül");
                    break;
                case10:
                    Console.WriteLine("Ekim");
                case 11:
                    Console.WriteLine("Kasım");
                    break;
                case 12:
                       Console.WriteLine("Aralık");
                    break;

                    Console.ReadLine();
            }

        }
    }
}
