using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace SerBusFunctionApp
{
    public class Function1
    {
        private readonly ILogger _logger;

        private static HttpClient client2 = new HttpClient();

        public Function1(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<Function1>();
        }

        [Function("Function1")]
        public void Run([ServiceBusTrigger("myinputqueue", Connection = "sbconnstring")] string myQueueItem)
        {
            _logger.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");

            //var status = SendHttpRequest();
            var sendClass = new SendClass();
            var status = sendClass.SendStaticHttpRequest(ref client2);


            _logger.LogInformation($"Status Response from Bing.com: {status}");

        }
    }
}
