using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Bir sayı giriniz: ");
            int sayı = Convert.ToInt32(Console.ReadLine());

            if (sayı % 2 == 0) 
            {
           
                Console.WriteLine("sayı çifttir");
            }
            

         else
            {
                Console.WriteLine("sayı tektir");
            }


        }
    }
}
