using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class FixerIO
    {
        public string Base { get; set; }
        public string date { get; set; }
        public string url { get; set; }
        public Dictionary<string, double> rates;

        public FixerIO fixSample;
        public void CurrenciyleriCekVeAyristir()
        {
            try
            {
                string jsontext = new WebClient().DownloadString(url);

                fixSample = JsonConvert.DeserializeObject<FixerIO>(jsontext);
            }

            catch
            {
                Console.WriteLine("ilk girilen döviz verisi bulunamadı.");
            }
           
        }

        public void CurrencyHesapla(int miktar,String ilkCur,String ikinciCur)
        {
            double d2 = fixSample.rates[ikinciCur];
            double sonuc = d2 * miktar;
            Console.WriteLine(sonuc+" "+ikinciCur);

        }
    }
}
