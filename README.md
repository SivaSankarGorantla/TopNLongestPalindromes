### Task ###

Write an application that finds the 3 longest unique palindromes in a supplied 
string. For the 3 longestpalindromes, report the palindrome, start index and 
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

1. Clone the branch and open the PalindromeDetector.sln in Visual studio. FYI, I used Visual studio 2019.
2. Set PalindromeDetectorClient as start up project. 
3. Build the solution either in debug mode or release mode. 
4. Run the solution. 
5. When the application is running enter the input string the text boxt next to input. And click on the Find button to see the results. 

### Assumptions ###

1. A string with single character is not considered as palindrome. 
2. The application will print top 3 longest palindromes. If in a given string only one palindrome present, it displays that one pallindrome only. We can add a check it should display the result only when the list contains three unique palindromes. 
3. I tried to make the application responsive so that user can play with rest of the application. It is possible to discard the current session and start a new session by entering new string in the input text box and clicking on the button. 
4. We can further optimize it however, since it is adviced not to spend more than couple of ours, submitting it as is. 

### More details about projects ###

The solution is created using VS2019 and on .NetFrameWork 4.8. It contains following projects.

1. PalindromeDetectorClient: This is a WPF project. This needs to be set as start up project in visual studio to run the application. 
2. PalindromeDetectorModel: This is model layer that contains all the business logic. 
3. PalindromeDetectorModelTests : Unit test project for PalindromeDetectorModel project.
4. PalindromeDetectorClientTests : Unit test project for PalindromeDetectorModel project. Writing unit test for view models still pending. 



