# IntegrationPoC
Web API Integration PoC
# REST API desing with .net core
This repository contains an example API written in C# and ASP.NET Core.  

# Getting Started

To install this example application, run the following commands:

git clone https://github.com/techs12/IntegrationPoC.git

<a href="https://dotnet.microsoft.com/learn/dotnet/what-is-dotnet" rel="nofollow">More about .NET Core</a><br>
<a href="https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-6.0" rel="nofollow">ASP.NET Core</a><br>
<a href="https://blog.scottlogic.com/2016/09/05/hosting-netcore-on-linux-with-docker.html" rel="nofollow">HOSTING .NET CORE ON LINUX WITH DOCKER - A NOOB'S GUIDE</a><br>
<a href="https://hub.docker.com/_/microsoft-dotnet-core" rel="nofollow">Microsoft/dotnet docker image</a><br>

# Run local with CLI
1. Clone or download this repository to local machine.
2. Install <a href="https://dotnet.microsoft.com/download#windowscmd" rel="nofollow">.NET Core SDK for your platform</a><br>
3. dotnet restore
4. dotnet run

# Run on Visual Studio
1. Install <a href="https://visualstudio.microsoft.com/vs/" rel="nofollow">Visual Studio 2019 for your platform</a><br> 
2. Open project
3. Debug -> Start debugging

# Run a docker container:
1. Clone or download this repository to local machine.
2. Install <a href="https://www.docker.com/" rel="nofollow">Docker for your platform</a><br> 
3. sudo docker build -t enter-name-your-docker-container.
4. sudo docker run -p 5000:5000 -it enter-name-your-docker-container or sudo docker run -p 5000:5000 -d enter-name-your-docker-container to run detached.

# Update appsettings.json
"AppSettings": {
    "ClientApiURL": "Provide api url"
  },
  
  ![image](https://user-images.githubusercontent.com/43737650/140649362-5c3057bf-bf69-4976-8e67-482e676fc3fc.png)
  ![image](https://user-images.githubusercontent.com/43737650/140649415-543eb8cb-c5e9-4ce0-be8e-83187251c834.png)
  ![image](https://user-images.githubusercontent.com/43737650/140649472-89bf2b69-2666-4f42-b804-079fe8cf6926.png)
  ![image](https://user-images.githubusercontent.com/43737650/140649493-ca284f3f-9ee7-44a5-b704-bbc8709bc719.png)

# YAML-defined CI/CD for ASP .NET Core
<a href="https://docs.microsoft.com/en-us/azure/devops/pipelines/ecosystems/dotnet-core?view=azure-devops&tabs=dotnetfive" rel="nofollow">Build, test, and deploy .NET Core apps</a><br>
<a href="https://wakeupandcode.com/yaml-defined-ci-cd-for-asp-net-core-3-1/" rel="nofollow">YAML-defined CI/CD for ASP .NET Core</a><br>

# Create a CI/CD pipeline for .NET with the Azure DevOps Project 

<a href="https://www.azuredevopslabs.com/labs/vstsextend/azuredevopsprojectdotnet/" rel="nofollow">Create a CI/CD pipeline for .NET with the Azure DevOps Project</a><br>






