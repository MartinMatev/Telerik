/*
    COPY PASTE THE FOLLOWING CODE IN THE BROWSER'S CONSOLE ! 
*/

/*
Problem 8. Trapezoid area

Write an expression that calculates trapezoid's area by given sides a and b and height h.
Examples:

a	    b	    h	    area
5	    7	    12	    72
2	    1	    33	    49.5
8.5	    4.3	    2.7	    17.28
100	    200	    300	    45000
0.222	0.333	0.555	0.1540125
*/

var firstA = 5;
var firstB = 7;
var firstH = 12;

var secondA = 2;
var secondB = 1;
var secondH = 33;

var thirdA = 8.5;
var thirdB = 4.3;
var thirdH = 2.7;

var fourthA = 100;
var fourthB = 200;
var fourthH = 300;

var fifthA = 0.222;
var fifthB = 0.333;
var fifthH = 0.555;

console.log(getArea(firstA, firstB, firstH));
console.log(getArea(secondA, secondB, secondH));
console.log(getArea(thirdA, thirdB, thirdH));
console.log(getArea(fourthA, fourthB, fourthH));
console.log(getArea(fifthA, fifthB, fifthH));

function getArea(a, b, h) {
    return ((a + b) / 2) * h;
}