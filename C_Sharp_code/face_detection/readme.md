# Face Detection - C# Code Sample

If you want to test the Face Detection functionality, using C#, you can use the project in this folder.  The application is a .NET Core application so you can run the code in the Visual Studio Code online environment, or you can clone this repo to your local computer and run the projects there.  Because it is using .NET Core, it will run on Windows, Mac, and Linux platforms in the same manner.

1. Open **Program.cs**
1. In Main, paste your *endpoint* and *authorization key*, for the Cognitive Service you created, into the placeholders.
1. Inspect the code to see how the methods are written.
1. This code makes use of a publicly accessible image repository that may not be available at all times.  If so, you can replace the **IMAGE_BASE_URL** constant with another URL containing free images that might contain faces.
1. After reviewing the code, right-click the **face_detection** folder and choose **Open in Terminal**.
    ![NOTE] This step is important to ensure you are not attempting to run some other project.
1. A new Terminal window opens at the bottom of the VS Code window.
1. Type the following command to run the program, ```dotnet run``` and press Enter.
1. The results should display in the Terminal window indicating if faces were detected in the supplied images.
