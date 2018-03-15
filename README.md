# Convert Number Into Words

This Web application converts Number into Words. It has two parts, one WebAPI and one Angular based Web Application.

## Features
* Will capture a person's name (ex. John Doe) and a number (ex. 123.45)
* Convert this number into words.
* Render this name and number (as words) in a web page.
* Converted words will be displayed with currency name DOLLAR and CENTS.

## Technology used:

* Web API with ASP.NET Core 2.0
* Angular CLI - version 1.7.3. (https://github.com/angular/angular-cli)
* xUnit 2.2.0

## Pre-requisite to run the application

* For .Net core: Microsoft Visual Studio 2017 - Version 15.4.3
* For Angular 4: Please install node from (https://nodejs.org/en/download/)
* Need to install angular CLI using command prompt "npm install -g @angular/cli" , help: ("https://angular.io/guide/quickstart")


## To run the Solution

### Web API
* To launch the web service open the solution "ConvertNumberIntoWords.sln" in VS 2017, set "ConvertNumberIntoWords" project as Startup.
* Hit F5, the solution will Restore all necessary nuget packages (or manually Restore all NuGet packages) and a Web API will launch, in the browser UI will display the message "Conversion service API is running".

### Front-end Application
* For the front-end web application, using command prompt navigate to the directory "\ConversionWebApp" and run "npm install"
-which will download necessary angular modules, then run "ng serve --open", which will launch the web application or user can browse "http://localhost:1444/". This web applcation will consume the Web API.

### Unit test
* xUnit test project "ConvertNumberIntoWord.Tests" is added in the visual studio solution to cover some of the scenarios.


Once both the application is up and running, it is ready to use.

Thanks.
