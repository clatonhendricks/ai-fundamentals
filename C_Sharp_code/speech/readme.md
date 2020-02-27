# Speech - C# Sample Code

This code sample is intended to mimic the Python code that is used to transcribe speech. The application is a .NET Core application so you can run the code in the Visual Studio Code online environment, or you can clone this repo to your local computer and run the projects there.  Because it is using .NET Core, it will run on Windows, Mac, and Linux platforms in the same manner.

1. Open **Program.cs**
1. In Main, paste your *region* and *authorization key*, for the Cognitive Service you created, into the placeholders.  In this case, you are using a region rather than an endpoint URL.  The region you enter should be something like **westus**.
1. Inspect the code to see how the methods are written.
1. After reviewing the code, right-click the **speech** folder and choose **Open in Terminal**.
    ![NOTE] This step is important to ensure you are not attempting to run some other project.
1. A new Terminal window opens at the bottom of the VS Code window.
1. Type the following command to run the program, ```dotnet run``` and press Enter.
1. The results should display in the Terminal window with a description of the image.
