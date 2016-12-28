using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            task2();
            task3();
            task4();

            Console.Read();
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
