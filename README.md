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

After you've completed the setup steps above, you can use your Visual Studio Online environment to complete the labs.

- **Lab 1A: Introduction to Machine Learning**. In this lab, you'll learn about the foundation of modern AI - machine learning. You'll use Microsoft Azure Machine Learning' automated machine learning interface to train a machine learning model that predicts how many customers a cycle rental company should expect on a given day, taking into account the day of the week, season, and weather conditions. You'll then publish the trained model as a service and use it from a simple client application.
- **Lab 1B: Classification with Azure ML Designer**. In the previous lab, you used automated machine learning to create a machine learning model that predicts a numeric value (a technique called *regression*). In this lab, you'll use a visual designer to create a machine learning model that predicts whether a patient at a clinic is diabetic or not (a technique called *classification*).
- **Lab 2A: Introduction to Computer Vision**. In this lab, you'll explore one of the core AI challenges - enabling an application to look at the world, and make sense of what it sees. You'll use Azure Cognitive Services to analyze images, build your own custom image classification model to monitor a retail store and identify produce in an automated checkout system.
- **Lab 2B: Optical Character Recognition**. A common use of computer vision is to create solutions that can read and interpret text in an image. In this lab, you'll explore Cognitive Services that you can use to locate and read text in images and forms.
- **Lab 3A: Introduction to Natural Language Processing**. Natural Language Processing (NLP) is the area of AI that focuses on enabling computers to interpret text and speech. In this lab, you'll use use the Text Analytics Service to analyze text, extracting key phrases and sentiment.
- **Lab 3B: Language Understanding**. In this lab, you'll use the Language Understanding Intelligence Service (LUIS) to create a simple language model that understands commands to control devices like lights and fans. Then, you'll use the Speech cognitive service to transcribe spoken commands into text - enabling your LUIS application to be used for voice controlled device automation.
- **Lab 4: Conversational AI**. In this lab, you'll use the QnA Maker service to create a knowledge base that enables an AI agent for a cycle rental company to answer questions from customers. Then you'll create a *bot* that uses the knowledge base and enables customers to engage your AI service in conversational exchanges through channels such as web chat and email.

> **Note**: Labs that involve running code include all of the code you'll need - you'll just need to copy and paste a few values and run the code that is provided, so don't worry if you're not a programmer! We've used Python code in the labs, because that can be run interactively in the notebooks themselves. If you prefer to see Microsoft C# versions of the lab solutions, you'll find them in the **C_Sharp_code** folder.
