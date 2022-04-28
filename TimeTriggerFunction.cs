using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace TimeTriggerFunctionApp
{
    public class TimeTriggerFunction
    {
        //private static string triggerExpression = "*/1 * * * * *";

        public TimeTriggerFunction()
        {
                
        }

        [FunctionName(nameof(TimeTriggerFunction))]
        public void Run([TimerTrigger("*/5 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
