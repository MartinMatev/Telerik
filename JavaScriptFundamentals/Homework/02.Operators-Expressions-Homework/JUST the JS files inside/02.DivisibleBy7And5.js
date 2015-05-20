/*
    COPY PASTE THE FOLLOWING CODE IN THE BROWSER'S CONSOLE ! 
*/

/*
Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
    Examples:

n	Divided by 7 and 5?
3	false
0	true
5	false
7	false
35	true
140	true
*/

var three = 3;
var zero = 0;
var five = 5;
var seven = 7;
var thirtyFive = 35;
var hundredFourty = 140;

console.log("Is 3 divisible by BOTH 5 and 7? - " + isDivisible(three));
console.log("Is 0 divisible by BOTH 5 and 7? - " + isDivisible(zero));
console.log("Is 5 divisible by BOTH 5 and 7? - " + isDivisible(five));
console.log("Is 7 divisible by BOTH 5 and 7? - " + isDivisible(seven));
console.log("Is 35 divisible by BOTH 5 and 7? - " + isDivisible(thirtyFive));
console.log("Is 140 divisible by BOTH 5 and 7? - " + isDivisible(hundredFourty));

function isDivisible(number){
    return number % 5 == 0 && number % 7 == 0;
}