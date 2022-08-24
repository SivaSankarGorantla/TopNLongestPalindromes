### Task ###

Write an application that finds the 3 longest unique palindromes in a supplied 
string. For the 3 longest palindromes, report the palindrome, start index and 
length, in descending order of length.

### Example Output ###

Given the input string: `sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpop`, the 
output should be:

Text: hijkllkjih, Index: 23, Length: 10

Text: defggfed, Index: 13, Length: 8

Text: abccba, Index: 5 Length: 6

### Deliverables ###

-  Your solution may be submitted in a language of your choice.
-  Please include instructions for how to build and run your code.
-  Don't forget to include any tests in the package.

### Guidance ###

-  You shouldn't spend more than a couple of hours on the solution.
-  We expect candidates to create code that is production quality - the solution 
should be correct, reliable, maintainable, reusable, portable and efficient.
-  For further guidance see Clean Code: A Handbook of Agile Software 
Craftsmanship by Robert C.Martin.

### Instructions to run the solution ###

1. Clone the branch and open the PalindromeDetector.sln in Visual studio. FYI, I used Visual Studio 2019.
2. Set PalindromeDetectorClient as a start-up project. 
3. Build the solution either in debug mode or release mode. 
4. Run the solution. 
5. When the application is running enter the input string in the text box next to the input. And click on the Find button to see the results. 

### Assumptions ###

1. A string with a single character is not considered a palindrome. 
2. The application will print the top 3 longest palindromes. If in a given string only one palindrome is present, it displays that one palindrome only. We can add a check it should display the result only when the list contains three unique palindromes. 
3. I tried to make the application responsive so that the user can play with the rest of the application. It is possible to discard the current session and start a new session by entering a new string in the input text box and clicking on the button.
4. We can further optimize it, however, since it is advised not to spend more than a couple of ours, submitting it as is. 

### More details about projects ###

The solution is created using VS2019 and on.NetFrameWork 4.8. It contains the following projects.

1. PalindromeDetectorClient: This is a WPF project. This needs to be set as a start-up project in visual studio to run the application. 
2. PalindromeDetectorModel: This is a model layer that contains all the business logic. 
3. PalindromeDetectorModelTests: Unit test project for PalindromeDetectorModel project.
4. PalindromeDetectorClientTests : Unit test project for PalindromeDetectorModel project. Writing unit test for view models still pending. 

### Improvements to be done* ###
1. Using commands instead of hanlding events in the code behind. 
2. Providing a cancel button for ease of use.
3. Showing the progress bar.
4. Writing unit tests for VMs.
