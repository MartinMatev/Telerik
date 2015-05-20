/*
    COPY PASTE THE FOLLOWING CODE IN THE BROWSER'S CONSOLE ! 
*/

/*
Problem 1. Odd or Even
Write an expression that checks if given integer is odd or even.
    Examples:

n	Odd?
3	true
2	false
-2	false
-1	true
0	false
*/

var isThreeOdd = 3 % 2 != 0;
var isTwoOdd = 2 % 2 != 0;
var isMinusTwoOdd = -2 % 2 != 0;
var isMinusOneOdd = -1 % 2 != 0;
var isZeroOdd = 0 % 2 != 0;

console.log("Is 3 Odd? - " + isThreeOdd);
console.log("Is 2 Odd? - " + isTwoOdd);
console.log("Is -2 Odd? - " + isMinusTwoOdd);
console.log("Is -1 Odd? - " + isMinusOneOdd);
console.log("Is 0 Odd? - " + isZeroOdd);

/*
    Cycle through the array of boolean var, and dispay their value
    Downside: Doesnt display the number being evaluated
*/

//var collection = [isThreeOdd, isTwoOdd, isMinusTwoOdd, isMinusOneOdd, isZeroOdd];
//collection.forEach(function(entry){
//    console.log("Is odd? - " + entry);
//});