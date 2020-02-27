using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace AI_ML_Fundamentals
{
    // The data structure expected by the service

    internal class InputData
    {
        [JsonProperty("data")]

        internal double[,] data;
    }

    // The data structure for deserializing the returned JSON
    internal class Rent
    {
        [JsonProperty("result")]
        public List<float> result { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Set the scoring URI and authentication key or token
            string scoringUri = "YOUR_ENDPOINT";
            string authKey = "YOUR_KEY";

            // Features based on a five-day weather forecast
            InputData payload = new InputData();
            payload.data = new double[,] {
               {1, 1, 2022, 1, 0, 6, 0, 2, 0.344167, 0.363625, 0.805833, 0.160446}, 
            {2, 1, 2022, 1, 0, 0, 0, 2, 0.363478, 0.353739, 0.696087, 0.248539}, 
            {3, 1, 2022, 1, 0, 1, 1, 1, 0.196364, 0.189405, 0.437273, 0.248309}, 
            {4, 1, 2022, 1, 0, 2, 1, 1, 0.2, 0.212122, 0.590435, 0.160296}, 
            {5, 1, 2022, 1, 0, 3, 1, 1, 0.226957, 0.22927, 0.436957, 0.1869}
            };

            // Create the HTTP client
            HttpClient client = new HttpClient();

            // Set the auth header. Only needed if the web service requires authentication.
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authKey);

            // Make the request
            try {
                // setup the request object using a POST method and passing in the endpoint
                var request = new HttpRequestMessage(HttpMethod.Post, new Uri(scoringUri));

                // Serialize the data into JSON
                request.Content = new StringContent(JsonConvert.SerializeObject(payload));

                // Set the content type
                request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                // Send the request, assigning the result to the response variable
                var response = client.SendAsync(request).Result;
                
                // Assign the result to a string so we can perform some manipulation
                string jsonResult = (response.Content.ReadAsStringAsync().Result);
                
                // the returned result may contain backslash (\) and/or quotes (")
                // at the beginning of the JSON response.
                // we need to remove them for the deserialization to succeed
                jsonResult = jsonResult.Replace(@"\", String.Empty);
                jsonResult = jsonResult.Replace("\"", String.Empty);

                // Deserialize the JSON into our Rent object
                Rent rents = JsonConvert.DeserializeObject<Rent>(jsonResult,
                    new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore});
                
                // Output the display in a formatted viewing
                Console.WriteLine("Predictions:");
                int day = 1;

                foreach(float f in rents.result)
                {
                    Console.WriteLine("Day: " + day + ". Predicted rentals: " + Convert.ToInt32(f));
                    day++;
                }

            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.Message);
            }
        }
    }
}