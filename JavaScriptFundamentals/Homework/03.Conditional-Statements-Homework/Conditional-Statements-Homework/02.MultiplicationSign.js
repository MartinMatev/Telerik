/*
    COPY PASTE THE FOLLOWING CODE IN THE BROWSER'S CONSOLE ! 
*/

/*
Problem 2. Multiplication Sign

Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.
Examples:

a	    b	     c	        result
5	    2	     2	        +
-2	    -2	     1	        +
-2	    4	     3	        -
0	    -2.5     4	        0
-1	    -0.5     -5.1	    -
*/

var firstSet = [5, 2, 2];
var secondSet = [-2, -2, 1];
var thirdSet = [-2, 4, 3];
var fourthSet = [0, -2.5, 4];
var fifthSet = [-1, -0.5, -5.1];

var collection = [firstSet, secondSet, thirdSet, fourthSet, fifthSet];
collection.forEach(findSign);

function findSign(set) {
    var negativeCounter = 0;
    var zero = false;

    set.forEach(function (number) {
        if (number == 0) {
            zero = true;
        }
        else if (number < 0) {
            negativeCounter++;
        }
    });

    if (zero) {
        console.log('0');
    }
    else {
        console.log((negativeCounter % 2) ? '-' : '+');
    }
}