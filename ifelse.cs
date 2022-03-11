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
            int time = DateTime.Now.Hour;

            if (time >= 6 && time <= 11)
            {
                Console.WriteLine("Gunaydın");
            }
            else if (time <= 18)
            {
                Console.WriteLine("iyi gunler");
            }
            else
            {
             Console.WriteLine("iyi geceler");
            }
            Console.ReadLine();
        }
    }
}
