Thank you for taking the time to review the completed coding interview challenge 

Following is the current requirements for this application. 

A string can be abbreviated by replacing any number of non-adjacent, 
non-empty substrings with their length. The length should not have leading zeros.
Give a string word and abbr , return whether the string matches the given abbreviation. 

For example
Word = “test” , abbr =”t2t”         returns true
Word = “test” , abbr =”t02t”         returns false

Following Test Cases are tested in this application : 
1) "foobar" abbr "f2b2"
2) "picon"  abbr "p3n"
3) "foobare" abbr "f2b3"
4) "foobar" abbr "g2d3"
5) “test” , abbr =”t2t”
6) “test” , abbr =”t02t”
   
NOTE:
There are 2 projects in the solution. Console Application Project and a Unit Testing Project.
  1. GeicoInterviewApp.csproj - is the Console application that will echo out the 6 test cases output whether the data is an abbreviation or not per the requirement.
  2.  GeicoInterviewAppTest.csproj - is the Unit testing application that uses xUnit and when executed will run all 6 defined test cases along with outputs and can be viewed if the test cases passed or failed via the VS Test Explorer.

THANK YOU GEICO !! for taking the time to interview me :D - Frank Picon 
