# StringData
Rest API for determining if a given string is a palindrome.  Will also return each unique character in the string along with a count of how often that character appears in the string.

This application was built using VS code using .Net Core version 3.1.  Newtonsoft JSON is utilized to pass the correct JSON output, and unit tests were set up and executed using Xunit.

You can test with the following URL if you're running the application locally (do note which localhost port is used):

https://localhost:5001/StringData/aaabbb

Where "aaabbb" is the string to be analyzed.  Output should be:

{"IsPalindrome":false,"SortedCharacterCount":[{"character":"a","count":3},{"character":"b","count":3}],"TimeStamp":"2020-06-06T17:23:59.1779465-05:00"}

Where timestamp will reflect the date and time the command ran.
