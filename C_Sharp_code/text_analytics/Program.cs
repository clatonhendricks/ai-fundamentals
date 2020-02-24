using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;
using Microsoft.Rest;


namespace text_analytics
{
    class Program
    {
        private static readonly string key = "YOUR_KEY";
        private static readonly string endpoint = "YOUR_ENDPOINT";

        static string reviewOne = File.ReadAllText("../../data/reviews/review1.txt");

        static string reviewTwo = File.ReadAllText("../../data/reviews/review2.txt");

        static void Main(string[] args)
        {
            var client = authenticateClient();

            sentimentAnalysisExample(client);
            keyPhraseExtractionExample(client);

            Console.Write("Press any key to exit.");
            Console.ReadKey();
        }

        static TextAnalyticsClient authenticateClient()
        {
            ApiKeyServiceClientCredentials credentials = new ApiKeyServiceClientCredentials(key);
            TextAnalyticsClient client = new TextAnalyticsClient(credentials)
            {
                Endpoint = endpoint
            };
            return client;
        }

        static void sentimentAnalysisExample(ITextAnalyticsClient client)
        {
            Console.WriteLine();
            Console.WriteLine(reviewOne);
            var result1 = client.Sentiment(reviewOne, "en");
            Console.WriteLine($"Sentiment Score: {result1.Score:0.00}");
            Console.WriteLine();

            Console.WriteLine(reviewTwo);
            var result2 = client.Sentiment(reviewTwo, "en");
            Console.WriteLine($"Sentiment Score: {result2.Score:0.00}");
            Console.WriteLine();
        }

        static void keyPhraseExtractionExample(TextAnalyticsClient client)
        {
            var result = client.KeyPhrases(reviewOne);

            // Printing key phrases
            Console.WriteLine("Key phrases:");

            foreach (string keyphrase in result.KeyPhrases)
            {
                Console.WriteLine($"\t{keyphrase}");
            }
        }

    }

    class ApiKeyServiceClientCredentials : ServiceClientCredentials
    {
        private readonly string apiKey;

        public ApiKeyServiceClientCredentials(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public override Task ProcessHttpRequestAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }
            request.Headers.Add("Ocp-Apim-Subscription-Key", this.apiKey);
            return base.ProcessHttpRequestAsync(request, cancellationToken);
        }
    }
}
