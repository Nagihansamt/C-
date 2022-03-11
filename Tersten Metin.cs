using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaWor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metin Giriniz");
            string metin = Console.ReadLine();

            Console.WriteLine("Metninizin Ters Hali");
            for(int i = metin.Length; i >= 0; i--)
            {
                Console.Write(metin[i]);
            }
            Console.ReadLine();
        }
         

          

            
        }
    }

