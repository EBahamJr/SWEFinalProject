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
Each piece of this project references only what is needs as per the requirements. The Calculator Functions class contains all of the code needed to make the calculator function. This is referenced by two things for different reasons but doesn't depend on any other classes for it to function. The Calculator Unit Tests class references the Calculator Functions class to run the necessary tests on it's individual pieces. The Calculator front end class references the Calculator Functions class to use it's methods in it's html to give an interface to the functionality it provides. Finally, the End to End Testing class doesn't reference anything directly as it's meant to test directly on the resulting webpage and therefore needs no dependancies. As long as the target port is correct.

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
To configure Playwright for end-to-end testing:
 1. Find the EndToEndTesting directory in terminal. (\\\\SWEFinalProject\src\EndToEndTesting)
 2. do `dotnet add package Microsoft.Playwright.NUnit`
 3. then do `dotnet build`
 4. [Ensure you have powershell downloaded](https://learn.microsoft.com/en-us/powershell/scripting/install/installing-powershell-on-windows?view=powershell-7.4)
 6. run `pwsh bin/Debug/net8.0/playwright.ps1 install` (Ensure net8.0 is replaced with your version of .net)
To Run the End To End Tests
 1. Navigate back to the CalculatorFrontEnd directory in command prompt. (\\\\SWEFinalProject\src\CalculatorFrontEnd)
 2. do `dotnet run`
 3. Go back to EndToEndTesting in terminal. (\\\\SWEFinalProject\src\EndToEndTesting)
 4. run `dotnet test` (may need to run twice, tends to miss-input the first box on the first attempt)

# Executing the Web Application
To prepare your environment to execute this application from the command line:
 1. Go to the CalculatorFrontEnd folder in command prompt. (\\\\SWEFinalProject\src\CalculatorFrontEnd)
 2. do `dotnet run`
 3. Terminal will output the address mixed in with some other information (should be http://localhost:5079).
```
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5079
etc, etc, etc
```
 4. Put it into the address bar of your chosen browser. (Reminder! it's http not https)
 6. `ctrl+c` to terminate the application.

# Executing Unit Test
To prepare your environment to execute this application from the command line:
 1. Go to the CalculatorUnitTests folder in command prompt. (ex: C:\Users\\`user`\\SWEFinalProject\src\CalculatorUnitTests)
 2. Enter command `dotnet test` into the terminal.
 6. The Terminal will spit out most of the test data you need

# Reviewing Unit Test Coverage
Disclaimer: This is excluding unused getter statements within the calculator functions class
![image](https://github.com/EBahamJr/SWEFinalProject/assets/40864286/5f5b364c-9beb-4bc8-af6e-eeb641149ec6)

# Executing End-To-End Tests


# Final Video Presentation
