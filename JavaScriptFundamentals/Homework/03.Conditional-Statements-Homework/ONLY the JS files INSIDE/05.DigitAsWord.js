/*
    COPY PASTE THE FOLLOWING CODE IN THE BROWSER'S CONSOLE ! 
*/

/*
Problem 5. Digit as word

Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
Print “not a digit” in case of invalid input.
Use a switch statement.
Examples:

digit	result
2	    two
1	    one
0	    zero
5	    five
-0.1    not a digit
hi	    not a digit
9	    nine
10	    not a digit
*/

var firstTestDigit = 2;
var thirdTestDigit = 1;
var fourthTestDigit = 0;
var fifthTestDigit = 5;
var sixthTestDigit = -0.1;
var seventhTestDigit = 'hi';
var eighthTestDigit = 9;
var ninthTestDigit = 10;

var collection = [firstTestDigit, thirdTestDigit, fourthTestDigit, fifthTestDigit, sixthTestDigit, seventhTestDigit, eighthTestDigit, ninthTestDigit];
collection.forEach(getWord);

function getWord(digit) {
    if (!isNaN(digit) && digit >= 0 && digit < 10) {
        switch (digit) {
            case 1: console.log("One"); break;
            case 2: console.log("Two"); break;
            case 3: console.log("Three"); break;
            case 4: console.log("Four"); break;
            case 5: console.log("Five"); break;
            case 6: console.log("Six"); break;
            case 7: console.log("Seven"); break;
            case 8: console.log("Eight"); break;
            case 9: console.log("Nine"); break;
            default: console.log("Zero"); break;
        }
    }
    else {
        console.log("Not a digit");
    }
}