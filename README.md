# Number Into Words HEXAGON
A cheque writing program is one that takes a number as input, and converts this number into words. These words are then output as a string.

## Approach
My approach was to use arrays containing the corresponding string for predefinid values according to the language.

Another approach studied to solve the problem was to use conditional (if-else) to translate the value informed by the user, but due to the hight cyclomatic complexity of the programa, this approach was not adopted.

In the main method, recursion was used dueto values greater than 100.

## Test Plan
The purpose of the project is to receive a value via command line, and translate it into words.

Basically, the requirement to be tested is the conversion of a decimal (currency) value to its description using words.

The program works on command line, so just open the executable (inside the Exe folder), type a decimal number and see the translate. At the end of the tests, just type "exit" to close.

Possible tests:
 
- No decimal values like a string;
- Integer values;
- Decimal values;
- Decimal values with string;
- The "exit" word;

## Application
The application works on command line, accepting any numeric value to conversion. If any invalid value is entered, the system will ask for a new value.

## Execution
To run the application, is advisable to install the .Net Runtime 5.0, the installer is on the root folder. The executable is inside the Exe folder, in the root.
