using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {


            //kulanıcıya nasıl işlem yapmak istediğini sor.
            //1-bakiye görüntüleme
            //2-para çekme
            //3-para yatırma
            //q- çıkış

            int bakiye = 1500;

            Console.WriteLine("yapmak istediğiniz işlemi seçiniz: ");
            Console.WriteLine("işlemler sırası ile şöyledir 1-) bakıye görüntüleme \n 2-)para çekme \n 3-)para yatırma \n q-çıkış");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("bakiyeniz:" + bakiye);
            }
            else if (secim == "2")
            {
                Console.WriteLine("çekeceğiniz tutarı giriniz: ");
               int cekilentutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kalan tutar" + (bakiye - cekilentutar));
            }
            else if (secim == "3")
            {
                Console.WriteLine("yatıracağınız tutarı giriniz: ");
              int yatırılan_tutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Yeni bakiyeniz:" + (bakiye + yatırılan_tutar));
            }



            else if (secim == "4")

            {



                Console.WriteLine("bankamatikten çıkış yapılıyor...");
                Console.WriteLine("İyi Günler Dileriz....");
            }

            }
           



            }
        }





