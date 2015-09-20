using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace ShouldWorkServiceConsumeTest
{
    public class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(Environment.NewLine + "Retreive a WorkDayStatus by zipcode:");
            JObject workstatus = GetWorkDayStatus(33417);
            Console.WriteLine(workstatus);


        }

        public static JObject GetWorkDayStatus(int zipcode)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response =
                client.GetAsync("http://localhost:52021/api/IsGoodDayToWork/" + zipcode).Result;
            return response.Content.ReadAsAsync<JObject>().Result;
        }
    }
}
