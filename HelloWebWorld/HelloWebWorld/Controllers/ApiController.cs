using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWebWorld.Controllers
{
    public class ApiController : System.Web.Http.ApiController
    {
        public class Doviz
        {
            public string currency { get; set; }
            public double amount { get; set; }
        }


        // GET: api/Default
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/api?from=USD&to=EUR&amount=111
        public string Get(string from, string to,int amount)
        {
            
            Doviz d = new Doviz();
            FixerIO fix = new FixerIO
            {
                url = "http://api.fixer.io/latest?base=" + from
            };

            fix.CurrenciyleriCekVeAyristir();
            d.currency = to;
            double miktar= fix.rates[to];
            d.amount = miktar;
            string json = JsonConvert.SerializeObject(d);
            return json;
        }

        // POST: api/Default
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Default/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Default/5
        public void Delete(int id)
        {
        }
    }
}
