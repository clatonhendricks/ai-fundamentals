# Natural Language - C# Code

If you want to test natural language and LUIS, using C#, you can use the project in this folder.  The application is a .NET Core application so you can run the code in the Visual Studio Code online environment, or you can clone this repo to your local computer and run the projects there.  Because it is using .NET Core, it will run on Windows, Mac, and Linux platforms in the same manner.

1. Open **Program.cs**
1. In Main, paste the LUIS specific information for the LUIS app you created, into the appropriate placeholders.
1. In case you don't recall the instructions, you will find the AppID on Application Information page and the key and endpoint on the Azure Resources page, for you LUIS app.
1. Inspect the code to see how the methods are written.  
1. The method where most of the action takes place is the **GetPredictionAsync** method.
1. After reviewing the code, right-click the **Natural_Language** folder and choose **Open in Terminal**.
    ![NOTE] This step is important to ensure you are not attempting to run some other project.
1. A new Terminal window opens at the bottom of the VS Code window.
1. Type the following command to run the program, ```dotnet run``` and press Enter.
1. The results should display in the Terminal window showing the intent that was detected, along with a decimal value, which represents the percentage score of the prediction for the intents that are present.
1. Once you have run this the first time, go to line 71, where the query string **turn on the light** is located.  Replace that string with the commands that were tested in the Python examples. This will allows you to see how the LUIS service detects the various commands.
1. Enter the text **start the engine** in the query text string and run the code again.  In this case, note there is avery slight matching, 0.144 or 14% match.  Why is this?  Look at the intents and notice that neither start nor engine are present.  This shows a part of the training works in LUIS.  There may be *some* similarity in the utterance that is producing this result.
1. Also note that with **start the engine**, no devices were returned, like there were with fan and light.  That is because there were no entries made for engine, as a device.
1. If you would like, on line 79, set **verbose** to **true** and run the project again.  You will see more details in the response sent back from LUIS.
1. You can also change the showAllIntents attribute to true and you will get all the available intents returned with a matching percentage value next to those.  It's sometimes helpful to do so and get a feel for how the training of the model has produced the results for matches.
