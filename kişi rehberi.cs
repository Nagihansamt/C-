using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string[] ogrno = { "11", "12", "13", "14","15",};
                string[] isim = { "fatma", "nagihan", "asiye" , "orhan","muzaffer"};
                string[] mail = { "fatma@gmail.com", "nagihan0@gmail.com", "orhan@gmail.com", "asiy@gmail.com","muzo@gmail.com" };
                string[] telefon = { "044043", "04894949", "843797", "4248","023804284","3929283" };


                Console.Write("Kişi No'yu girin: ");
                string aranan = Console.ReadLine();
                int no = Array.IndexOf(ogrno, aranan.ToString());
                Console.WriteLine("===========================================================================");
                Console.WriteLine("Aranan Kişi : {0}\tTelefonu: {1}\tE-mail: {2}", isim[no], telefon[no], mail[no]);
                Console.ReadKey();
            }





        }
    }
}











    