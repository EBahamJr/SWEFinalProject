# KSU SWE 3643 Software Testing and Quality Assurance Semester Project: Web-Based Calculator
This repository contains the files and associated test for my web based calculator application

## Table of Contents
- [Team Members](#team-members )
- [Architechture](#architecture)
- [Environment](#environment)
- [Executing the Web Application](#executing-the-web-application )
- [Executing Unit Test](#executing-unit-test )
- [Reviewing Unit Test Coverage](#reviewing-unit-test-coverage )
- [Executing End-To-End Tests](#executing-end-to-end-tests )
- [Final Video Presentation ](#final-video-presentation )

# Team Members
Eric Baham Jr. as a solo act.

# Architecture
Each piece of this project references only what is needs as per the requirements. The Calculator Functions class contains all of the code needed to make the calculator function. This is referenced by two things for different reasons but doesn't depend on any other classes for it to function. The Calculator Unit Tests class references the Calculator Functions class to run the necessary tests on it's individual pieces. The Calculator front end class references the Calculator Functions class to use it's methods in it's html to give an interface to the functionality it provides. Finally, the End to End Testing class doesn't reference anything directly as it's meant to test directly on the resulting webpage and therefore needs no dependancies, though I don't believe that it's functional at this point in time.

![image](https://github.com/EBahamJr/SWEFinalProject/assets/40864286/97f09eab-c548-4eb1-b5c6-8eeb6eceb660)


# Environment
This is a cross-platform application and should work in Windows 10+, Mac OSx Ventura+, and Linux environments. Note that the application has only been carefully tested in Windows 11.

To prepare your environment to execute this application:
 1. [Install the 2022 c# runtime for your system.](https://visualstudio.microsoft.com/downloads/)
 2. Clone This Repository
 3. Open in Visual Studio
 4. Right Click on CalculatorFrontEnd in the solutions explorer and set it as the start up project.
 5. In the top-middle of the screen, click ![image](https://github.com/EBahamJr/SWEFinalProject/assets/40864286/eb18b86f-717d-4fb6-8a24-f9aa0fe9733d)
 6. Enjoy your new calculator!

# Executing the Web Application
To prepare your environment to execute this application from the command line:
 1. Navigate to the CalculatorWebApp directory in terminal/command prompt. (ex: C:\Users\\`user`\\RiderProjects\swe3643-spring2024-project\src\CalculatorWebApp)
 2. Enter command `dotnet run` into the terminal.
 3. Terminal will output the localhost address (typically http://localhost:5079)
```
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5113
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
      Content root path: /Users/tagan/Documents/SchoolFiles/SoftwareTestingQA/SemesterProject/WebApp/swe3643-spring2024-project/src/CalculatorWebApp
warn: Microsoft.AspNetCore.HttpsPolicy.HttpsRedirectionMiddleware[3]
      Failed to determine the https port for redirect.
```
 4. Click the local host address link or type it into the address bar of your browser.
 5. `ctrl+c` to terminate the application.
# Executing Unit Test
# Reviewing Unit Test Coverage
# Executing End-To-End Tests
# Final Video Presentation
