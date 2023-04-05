using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerBusFunctionApp
{
    public class SendClass
    {
        public string SendHttpRequest()
        {
            var client = new HttpClient();

            var request = new HttpRequestMessage(HttpMethod.Get, "https://www.bing.com");

            var response = client.SendAsync(request).Result;

            return response.StatusCode.ToString();
        }

        public string SendStaticHttpRequest(ref HttpClient client2)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://www.bing.com");

            var response = client2.SendAsync(request).Result;

            return response.StatusCode.ToString();
        }
    }
}
