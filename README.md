# APIAutomation

#Table of contents
Introduction
Requirements
How to use it?
Highlight
How to run test?
Test Report and Log
Troubleshooting


#Introduction
The API Automation is an automation testing project based on SpecFlow + RestSharp + Nunit. This framework is BDD(Behavior-driven development), and it's written in C#. The sample API under test is Deck of Cards API(http://deckofcardsapi.com/).

#Requirements
This project requires Visual Studio 2019 community version or above.

#How to use it?
You can download the source code, open the solution ...\DeckOfCardsTesting\DeckOfCardsTesting.sln to view the entire project.
The project structure should look like below:
Dependencies - This folder contains all the dependencies required for this project.
Common - This folder contains the BaseClass.cs(Read the API URL, Path etc information) and the APICallClass.cs(include All the API calls function).
Features - SpecFlow features files. It defines the tests using the Gherkin Given-When-Then language.
Steps - This folder contains the steps definition for the feature files.
TestResults - This folder contains the HTML format test report and the test run log file.
appsettings.json - This folder contains the API URL, path etc config information.

#Highlight
The features file are orginazed by requirement for easy requirement traceability. Sample feature: <requirement ID - requirement name>.
All the test cases should be tagged as expected. Sample tags include: @sanity, @regression, @priority. All the scenario/test should include the test case ID: <TC_ST_L1_DrawCards_P0001>.
This test framework support multiple dataset iteration. The data is separated by pipe(|).

#How to run test?
User can run the test directly from visual studio->Test Explorer. Organize the test cases by different category, run particular test or test set.
User can also run the test from command line using <dotnet test>, below is a few sample commands:
dotnet test [options] <PROJECT | SOLUTION> [[--] <RunSettings arguments>...]]
Common options include:
  -h, --help                               Show command line help.
  -s, --settings <SETTINGS_FILE>           The settings file to use when running tests.
  -t, --list-tests                         List the discovered tests instead of running the tests.
  --filter <EXPRESSION>                    Run tests that match the given expression.
  
#Test Report and Log
The html format test report and log can be found within: ...\DeckOfCardsTesting\TestResults.
