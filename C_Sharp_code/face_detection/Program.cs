using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Azure.CognitiveServices.Vision.Face;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;

namespace face_detection
{
    class Program
    {
        static void Main(string[] args)
        {
            // The subscription key and endpoint for the cognitive service account
            string SUBSCRIPTION_KEY = "YOUR_KEY";
            string ENDPOINT = "YOUR_ENDPOINT";

            // Recognition01 is the model that recognizes or detects faces
            const string RECOGNITION_MODEL1 = RecognitionModel.Recognition01;

            // Call the authenticate method to authenticate with the service
            IFaceClient client = Authenticate(ENDPOINT, SUBSCRIPTION_KEY);

            // URL for the images.
            const string IMAGE_BASE_URL = "https://csdx.blob.core.windows.net/resources/Face/Images/";

            // Detect - get features from faces.
            DetectFaceExtract(client, IMAGE_BASE_URL, RECOGNITION_MODEL1).Wait();

        }

        /*
        *	AUTHENTICATE
        *	Uses subscription key and region to create a client.
        */
        public static IFaceClient Authenticate(string endpoint, string key)
        {
            return new FaceClient(new ApiKeyServiceClientCredentials(key)) { Endpoint = endpoint };
        }

        /* 
            * DETECT FACES
            * Detects features from faces and IDs them.
        */
        public static async Task DetectFaceExtract(IFaceClient client, string url, string recognitionModel)
        {
            Console.WriteLine("========DETECT FACES========");
            Console.WriteLine();

            // Create a list of images
            List<string> imageFileNames = new List<string>
                    {
                        "detection1.jpg",    // single female with glasses
                        // "detection2.jpg", // (optional: single man)
                        // "detection3.jpg", // (optional: single male construction worker)
                        // "detection4.jpg", // (optional: 3 people at cafe, 1 is blurred)
                        "detection5.jpg",    // family, woman child man
                        "detection6.jpg"     // elderly couple, male female
                    };

            foreach (var imageFileName in imageFileNames)
            {
                IList<DetectedFace> detectedFaces;

                // Detect faces with all attributes from image url.
                detectedFaces = await client.Face.DetectWithUrlAsync($"{url}{imageFileName}",
                        returnFaceAttributes: new List<FaceAttributeType> { FaceAttributeType.Accessories, FaceAttributeType.Age,
                FaceAttributeType.Blur, FaceAttributeType.Emotion, FaceAttributeType.Exposure, FaceAttributeType.FacialHair,
                FaceAttributeType.Gender, FaceAttributeType.Glasses, FaceAttributeType.Hair, FaceAttributeType.HeadPose,
                FaceAttributeType.Makeup, FaceAttributeType.Noise, FaceAttributeType.Occlusion, FaceAttributeType.Smile },
                        recognitionModel: recognitionModel);

                Console.WriteLine($"{detectedFaces.Count} face(s) detected from image `{imageFileName}`.");
            }
        }
    }
}
