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
            Console.WriteLine("Hello World");

            Lesson ls = new Lesson
            {
                Name = "c++",
                Code = "bu bir kod örneğidir."
            };

            string json = JsonConvert.SerializeObject(ls);

            Console.WriteLine(json);

            string jsontext = new WebClient().DownloadString("https://raw.githubusercontent.com/mhs/world-currencies/master/currencies.json");

            //Console.WriteLine(jsontex);
            var cur = JsonConvert.DeserializeObject<List<Currency>>(jsontext);

            foreach (var data in cur)
            {
                Console.WriteLine(data.cc+"\t"
                    +data.symbol+ "\t"
                    +data.name);
            }

            Console.Read();
        }
    }
}
