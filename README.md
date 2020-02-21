# AI Fundamentals

This repo contains some labs to help you get started with Artificial Intelligence (AI) using Microsoft Azure. These labs are designed to introduce you to some of the core concepts in AI, and the services in Azure that help you apply those concepts to build intelligent applications.

The labs are provided as notebooks that contain explanations of key AI, instructions to configure AI services in Azure, and code that you can run to use the services you've configured. Don't worry too much about the details of the code syntax in the labs, but instead focus on understanding the types of solution that you can build using AI services in Azure.

## Before You Start

To complete the labs, you'll need the following:

- A Microsoft Azure subscription. If you don't already have one, you can sign up for a free trial at [https://azure.microsoft.com](https://azure.microsoft.com).
- A Visual Studio Online environment. This provides a hosted instance of Visual Studio Code, in which you'll be able to run the notebooks for the lab exercises. To set up this environment:
    1. Browse to [https://online.visualstudio.com](https://online.visualstudio.com)
    2. Click **Get Started**.
    3. Sign in using the Microsoft account associated with your Azure subscription.
    4. Click **Create environment**. If you don't already have a Visual Studio Online plan, create one. This is used to track resource utlization by your Visual Studio Online environments. Then create an environment with the following settings:
        - **Environment Name**: *A name for your environment - for example, **ai-environment**.*
        - **Git Repository**: GraemeMalcolm/ai-fundamentals
        - **Instance Type**: Standard (Linux) 4 cores, 8GB RAM
        - **Suspend idle environment after**: 30 minutes
    5. Wait for the environment to be created, and then connect to it by clicking its name. This will open a browser-based instance of Visual Studio Code.
    6. Wait for a minute or so until the files in this repo have been loaded into the environment, and the color scheme changes to a light background with dark text. This is your indication that you're ready to start the labs (you can change the color scheme back to a dark background if you prefer - just click the **&#9881;** icon at the bottom left and select a new **Color Theme**).
    7. Note the numbered *.ipynb* files in the **Explorer** pane - these contain the lab exercises.

## Labs

After you've completed the setup steps above, you can use your Visual Studio Online environment to complete the labs, which are based on the hypothetical *Adventure Works Cycles* - a cycle rental company operating in a large city.

- **Lab 1: Introduction to Machine Learning**. In this lab, you'll learn about the foundation of modern AI - machine learning. You'll use Microsoft Azure Machine Learning to train a machine learning model that predicts how many bike rentals Adventure Works Cycles should expect on a given day, taking into account the day of the week, season, and weather conditions. You'll then publish the trained model as a service and use it from a simple client application.
- **Lab 2: Computer Vision**. In this lab, you'll explore one of the core AI challenges - enabling an application to look at the world, and make sense of what it sees. You'll use Azure Cognitive Services to analyze images, build your own custom image classification model to identify motor vehicles and cycles in traffic, and detect cyclist's faces.
- **Lab 3: Natural Language Processing**. In this lab, you'll use use the Text Analytics Service to analyze text, extracting key phrases and sentiment. Then you'll use the Language Understanding Intelligence Service (LUIS) to create a simple language model that understands commands to control devices like lights and fans. Finally, you'll use the Speech cognitive service to transcribe spoken commands into text - enabling your LUIS application to be used for voice controlled device automation.
- **Lab 4: Conversational AI**. In this lab, you'll use the QnA Maker service to create a knowledge base that enables an AI agent to answer questions from Adventure Works customers. Then you'll create a *bot* that uses the knowledge base and enables customers to engage your AI service in conversational exchanges through channels such as web chat and email.
