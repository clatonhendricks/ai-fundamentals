# AI Fundamentals

This repository contains some labs to help you get started with Artificial Intelligence (AI) using Microsoft Azure. These labs are designed to introduce you to some of the core concepts in AI, and the services in Azure that help you apply those concepts to build intelligent applications.

The labs are provided as notebooks that contain explanations of key AI, instructions to configure AI services in Azure, and code that you can run to use the services you've configured. Don't worry too much about the details of the code syntax in the labs, but instead focus on understanding the types of solution that you can build using AI services in Azure.

## Before You Start

To complete the labs, you'll need the following:

- A Microsoft Azure subscription. If you don't already have one, you can sign up for a free trial at <a href ='https://azure.microsoft.com' target='_blank'>https://azure.microsoft.com</a>.
- A Visual Studio Online environment. This provides a hosted instance of Visual Studio Code, in which you'll be able to run the notebooks for the lab exercises. To set up this environment:
    1. Browse to <a href ='https://online.visualstudio.com' target='_blank'>https://online.visualstudio.com</a>
    2. Click **Get Started**.
    3. Sign in using the Microsoft account associated with your Azure subscription.
    4. Click **Create environment**. If you don't already have a Visual Studio Online plan, create one. This is used to track resource utilization by your Visual Studio Online environments. Then create an environment with the following settings:
        - **Environment Name**: *A name for your environment - for example, **ai-environment**.*
        - **Git Repository**: GraemeMalcolm/ai-fundamentals
        - **Instance Type**: Standard (Linux) 4 cores, 8GB RAM
        - **Suspend idle environment after**: 120 minutes
    5. Wait for the environment to be created, and then click **Connect** to connect to it. This will open a browser-based instance of Visual Studio Code.
    6. Wait for a minute or so while the environment is set up for you. It might look like nothing is happening, but in the background we are installing some extensions that you will use in the labs. You'll see the following things happen:
        - The files in this repo will appear in the pane on the left.
        - The color scheme will change to a light background with dark text.
        - After a few minutes (during which there's no apparent activity, but in the background we're setting up the environment for you), a new file named **REFRESH NOW** will appear in the pane on the left. This is your indication that everything has been installed.
    7. After the **REFRESH NOW** file has appeared, refresh the web page to ensure all of the extensions are loaded and you're ready to start.
    8. Note the numbered *.ipynb* files in the **Explorer** pane - these contain the lab exercises.

> **Tip**: you can change the color scheme back to a dark background if you prefer - just click the **&#9881;** icon at the bottom left and select a new **Color Theme**.

## Labs

After you've completed the setup steps above, you can use your Visual Studio Online environment to complete the labs by running the notebooks in this project.

> **Note**: Labs that involve running code include all of the code you'll need - you'll just need to copy and paste a few values and run the code that is provided, so don't worry if you're not a programmer! We've used Python code in the labs, because that can be run interactively in the notebooks themselves. If you prefer to see Microsoft C# versions of the lab solutions, you'll find them in the **C_Sharp_code** folder.
