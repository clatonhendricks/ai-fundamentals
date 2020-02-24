using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.CognitiveServices.Language.LUIS.Runtime;
using Microsoft.Azure.CognitiveServices.Language.LUIS.Runtime.Models;

namespace Natural_Language
{
    class Program
    {

        // Use Language Understanding (LUIS) prediction endpoint key
        // to create authentication credentials
        private static string predictionKey = "YOUR_LUIS_KEY";

        // Replace with your endpoint URL
        private static string predictionEndpoint = "YOUR_PREDICTION_ENDPOINT";

        // Replace with your App ID for the LUIS app you created
        private static string appId = "YOUR_LUIS_APPID";


        static void Main(string[] args)
        {

            // Get prediction
            var predictionResult = GetPredictionAsync().Result;

            var prediction = predictionResult.Prediction;

            // Display query
            Console.WriteLine("Query:'{0}'", predictionResult.Query);
            Console.WriteLine("TopIntent :'{0}' ", prediction.TopIntent);

            foreach (var i in prediction.Intents)
            {
                Console.WriteLine(string.Format("{0}:{1}", i.Key, i.Value.Score));
            }

            foreach (var e in prediction.Entities)
            {
                Console.WriteLine(string.Format("{0}:{1}", e.Key, e.Value));
            }

            Console.Write("done");

        }

        static LUISRuntimeClient CreateClient()
        {
            var credentials = new ApiKeyServiceClientCredentials(predictionKey);
            var luisClient = new LUISRuntimeClient(credentials, new System.Net.Http.DelegatingHandler[] { })
            {
                Endpoint = predictionEndpoint
            };

            return luisClient;

        }

        static async Task<PredictionResponse> GetPredictionAsync()
        {

            // Get client 
            using (var luisClient = CreateClient())
            {

                var predictionRequest = new PredictionRequest
                {
                    Query = "turn on the light",
                };

                // get prediction
                return await luisClient.Prediction.GetSlotPredictionAsync(
                    Guid.Parse(appId),
                    slotName: "production",
                    predictionRequest,
                    verbose: false,
                    showAllIntents: true,
                    log: true);
            }
        }
    }
}
