using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace HelloWebWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            task2();
            task3();
            task4();
            task5();
            Console.Read();
        }
        public static void task5()
        {
            Console.WriteLine("\nçevirmek istediğiniz döviz birimini girin.\n örn: 120-TRY-USD");
            string birimler= Console.ReadLine();
            try
            {
                string[] doviz = birimler.Split('-');
                string m = doviz[0];
                string d1 = doviz[1];
                string d2 = doviz[2];

                FixerIO fix = new FixerIO
                {
                    url = "http://api.fixer.io/latest?base=" + d1
                };
                fix.CurrenciyleriCekVeAyristir();
                fix.CurrencyHesapla(int.Parse(m), d1, d2);
            }
            catch
            {
                Console.WriteLine("Belirtilen şekilde giriş yapılmadı!");
            }
        }
        public static void task4()
        {
            Currency currency = new Currency
            {
                url = "https://raw.githubusercontent.com/mhs/world-currencies/master/currencies.json"
            };
            currency.CurrenciyleriCekVeAyristir();

            currency.VeriyiEkranaBas();

        }

        public static void task3()
        {
            Lesson ls = new Lesson
            {
                Name = "c++",
                Code = "bu bir kod örneğidir."
            };

            string json = JsonConvert.SerializeObject(ls);

            Console.WriteLine(json+"\n");
        }

        public static void task2()
        {
            Console.WriteLine("Hello World\n");
        }
    }
}
