# Computer Vision - C# Sample Code

This code sample is intended to mimic the Python code that is used to describe an image, from the Custom Vision unit. The application is a .NET Core application so you can run the code in the Visual Studio Code online environment, or you can clone this repo to your local computer and run the projects there.  Because it is using .NET Core, it will run on Windows, Mac, and Linux platforms in the same manner.

1. Open **Program.cs**
1. In Main, paste your *endpoint* and *authorization key*, for the Cognitive Service you created in this unit, into the placeholders.
1. Inspect the code to see how the methods are written.
1. You will notice that this code contains a json_classes.cs file.  This is to aid in the de-serialization of the returned JSON from the service.  It is a common pattern in C#, when working with the serialization and de-serialization of JSON objects.  The Newtonsoft libraries work very well with class files that match the array of JSON objects returned.
1. In this code, we are only accessing one class, the Description class.  We are only after the contents of that portion of the JSON for this lesson
1. After reviewing the code, right-click the **Computer_Vision** folder and choose **Open in Terminal**.
    ![NOTE] This step is important to ensure you are not attempting to run some other project.
1. A new Terminal window opens at the bottom of the VS Code window.
1. Type the following command to run the program, ```dotnet run``` and press Enter.
1. The results should display in the Terminal window with a description of the image.

If you are interested in seeing what the returned JSON response is, we have pasted it here for your review.  Take a look at the objects returned and map them to the json_classes.cs file to get an understanding of how the de-serialization works.

```json
Response:

{
  "categories": [
    {
      "name": "trans_bicycle",
      "score": 0.99609375
    }
  ],
  "color": {
    "dominantColorForeground": "Grey",
    "dominantColorBackground": "Grey",
    "dominantColors": [
      "Grey"
    ],
    "accentColor": "466330",
    "isBwImg": false,
    "isBWImg": false
  },
  "description": {
    "tags": [
      "outdoor",
      "bicycle",
      "building",
      "parked",
      "brick",
      "sidewalk",
      "side",
      "street",
      "front",
      "leaning",
      "bench",
      "stone",
      "red",
      "sitting",
      "black",
      "brown",
      "sign",
      "stop",
      "meter",
      "woman",
      "dog",
      "post",
      "seat",
      "standing",
      "old",
      "city",
      "man",
      "laying",
      "blue"
    ],
    "captions": [
      {
        "text": "a bicycle parked in front of a brick building",
        "confidence": 0.9725743728808782
      }
    ]
  },
  "requestId": "b6ee059e-5944-44f3-bff1-d9343d16dfa2",
  "metadata": {
    "width": 375,
    "height": 500,
    "format": "Jpeg"
  }
}
```
