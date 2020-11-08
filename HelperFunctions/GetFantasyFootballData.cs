using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using HelperFunctions.Business;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace HelperFunctions
{
    public static class GetFantasyFootballData
    {
        [FunctionName("GetFantasyFootballData")]
        public static async Task Run([TimerTrigger("0 0 */8 * * *")]TimerInfo myTimer, Binder binder, ILogger log)
        {
            log.LogInformation($"{nameof(GetFantasyFootballData)} trigger function executed at: {DateTime.Now}");

            var random = new Random();
            var randNum = random.Next(3);
            if (randNum % 3 == 0)
            {
                log.LogInformation("Random chance suggests we should load data for Fantasy Football");

                var data = await GetData();

                string path = $"player-data/{DateTimeOffset.UtcNow:u}.json".Replace(":", String.Empty);
                using var writer = await binder.BindAsync<TextWriter>(new BlobAttribute(path));
                await writer.WriteAsync(data);

                log.LogInformation("Completed loading data and storing for Fantasy Football");
            }
        }

        private static async Task<string> GetData()
        {
            using var httpClient = HttpClientFactory.Create();
            using var response = await httpClient.GetAsync("https://fantasy.premierleague.com/api/bootstrap-static/");
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return json;
        }
    }
}
