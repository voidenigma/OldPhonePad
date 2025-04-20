OldPhonePad
OldPhonePad is a .NET application written in C# that simulates the behavior of an old phone keypad which identifies and cycles through value in key by pressing the same key in short succession.
This application includes a main program that outputs alphabetical letters for a given numeric value. Unit tests were written using xUnit.

.NET SDK 9.0 or later is required in order to run this application.

This project contains the two main following files:

Program.cs: Contains source code of the main application logic.
Programtest.cs: Contains source code of the unit test logic.

็How to get Started

Clone the repository to local machine using Bash or a terminal with:

git clone <repository-url>

To build the project, run:

dotnet build

in the main or root directory where Program.cs is located in local machine.

To run the application, navigate to the Program.cs directory and execute:

dotnet run OldPhonePad.cs

inside the main directory.

Run Unit Tests
To run the unit tests, execute:

dotnet build

in a separate directory from where Program.cs is located, update the reference using:

dotnet add [test directory].../OldPhonePadTests.csproj reference [application directory].../OldPhonePadApp.csproj

at last run:

dotnet test

in main directory and review the test reslut.

Application Features
Processes input strings which simulates an old phone keypad where it requires pressing the same key to change charecter.
Validates input strings and handles invalid characters that will outputs "?????" when encoter invalid input.
Repeating the same key will literate through letter index. Once repreated key exceed corresponding index range, cycle back to first letter index and repreat.
Includes unit tests for testing outputs correctness.

Unit Tests
Unit tests validates the behavior of the OldPhonePad method outputs in various scenarios.

For example:
Input: "33#" => Output: E
Input: "4433555 555666#" => Output: HELLO
Input: "6666" => Output: M
Invalid inputs, for example "001cc+" or characters sequence that doesn't end with "#",  will return "?????".

    Test Cases Example
          Input	                    Expected Output
           33#	                           E
          227*#	                         ?????
     4433555 555666#                       HELLO
   8 88777444666*664#	                   ?????
   66666555555333333#	                    NFL

License
This project was created as part of a job application for Iron and is available on this GitHub.