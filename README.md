# Wildcards Code Challenge

Have the function Wildcards(str) read str which will contain two strings separated by a space. The first string will consist of the following sets of characters: +, *, $, and {N} which is optional. The plus (+) character represents a single alphabetic character, the ($) character represents a number between 1-9, and the asterisk (*) represents a sequence of the same character of length 3 unless it is followed by {N} which represents how many characters should appear in the sequence where N will be at least 1. Your goal is to determine if the second string exactly matches the pattern of the first string in the input.<br/>

For example: if str is "++*{5} jtggggg" then the second string in this case does match the pattern, so your program should return the string true. If the second string does not match the pattern your program should return the string false.<br/>

# Examples
> Input: "+++++* abcdehhhhhh"<br/>
> Output: false<br/>

> Input: "$**+*{2} 9mmmrrrkbb"<br/>
> Output: true<br/>

# Code Coverage
Click the link below to view the Code Coverage

<a href="https://htmlpreview.github.io/?https://github.com/toniolatunji/wildcards/blob/main/Wildcards/Wildcards.Tests/Coverage/index.html" target="_blank">Code Coverage</a>
