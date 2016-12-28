using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Lesson ls = new Lesson();
            ls.Name = "c++";
            ls.Code = "bu bir kod örneğidir.";
            string json = JsonConvert.SerializeObject(ls);
            Console.WriteLine(json);
            Console.Read();

        }
    }
}
