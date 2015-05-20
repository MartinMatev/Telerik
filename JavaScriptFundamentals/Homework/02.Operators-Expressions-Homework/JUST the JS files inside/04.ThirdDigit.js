/*
    COPY PASTE THE FOLLOWING CODE IN THE BROWSER'S CONSOLE ! 
*/

/*
Problem 4. Third digit

Write an expression that checks for given integer if its third digit (right-to-left) is 7.
Examples:

n	        Third digit 7?
5	        false
701	        true
1732        true
9703        true
877	        false
777877	    false
9999799	    true
*/

var first = 5;
var second = 701;
var third = 1732;
var fourth = 9703;
var fifth = 877;
var sixth = 777877;
var seventh = 9999799;

console.log("Third digit in 5 is seven - " + isThirdDigitSeven(first));
console.log("Third digit in 701 is seven - " + isThirdDigitSeven(second));
console.log("Third digit in 1732 is seven - " + isThirdDigitSeven(third));
console.log("Third digit in 9703 is seven - " + isThirdDigitSeven(fourth));
console.log("Third digit in 877 is seven - " + isThirdDigitSeven(fifth));
console.log("Third digit in 777877 is seven - " + isThirdDigitSeven(sixth));
console.log("Third digit in 9999799 is seven - " + isThirdDigitSeven(seventh));

function isThirdDigitSeven(number) {
    return (Math.floor(number / 100) % 10) == 7;
}
