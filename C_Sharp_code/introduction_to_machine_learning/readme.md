# Introduction to Machine Learning - C# Code

If you want to test the machine learning training results, using C#, you can use the project in this folder.  The application is a .NET Core application so you can run the code in the Visual Studio Code online environment, or you can clone this repo to your local computer and run the projects there.  Because it is using .NET Core, it will run on Windows, Mac, and Linux platforms in the same manner.

1. Open **Program.cs**
1. In Main, paste your *endpoint* and *authorization key*, for the Machine Learning service you created in this unit, into the placeholders.
1. Inspect the code to see how the methods are written.  There is a portion of code that removes any double quotes and slashes that may be present in the returned JSON.  This ensures the JSON is valid.
1. For the purposes of deserializing the JSON, and so that we can provide a formatted output, we follow the pattern of creating the necessary classes to support the de-serialization.   The class is found at the top of the code file and is called Rent.
1. After reviewing the code, right-click the **introduction_to_machine_learning** folder and choose **Open in Terminal**.
1. A new Terminal window opens at the bottom of the VS Code window.
1. Type the following command to run the program, ```dotnet run``` and press Enter.
1. The results should display in the Terminal window in the same format as in the Python example.
