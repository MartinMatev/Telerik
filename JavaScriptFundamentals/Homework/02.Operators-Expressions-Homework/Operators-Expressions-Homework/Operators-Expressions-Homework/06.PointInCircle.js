/*
    COPY PASTE THE FOLLOWING CODE IN THE BROWSER'S CONSOLE ! 
*/

/*
Problem 6. Point in Circle

Write an expression that checks if given point P(x, y) is within a circle K(O, 5).
Examples:

x	    y	    inside
0	    1	    true
-5	    0	    false
-4	    5	    false
1.5	    -3	    true
-4	    -3.5    false
100	    -30	    false
0	    0	    true
0.2	    -0.8    true
0.9	    -4.93	false
2	    2.655	true
*/

var centerX = 0;
var centerY = 0;
var radius = 5;

var firstX = 0;
var firstY = 1;

var secondX = -5;
var secondY = 0;

var thirdX = -4;
var thirdY = 5;

var fourthX = 1.5;
var fourthY = -3;

var fifthX = -4;
var fifthY = -3.5;

var sixthX = 100;
var sixthY = -30;

var seventhX = 0;
var seventhY = 0;

var eighthX = 0.2;
var eighthY = -0.8;

var ninthX = 0.9;
var ninthY = -4.93;

var tenthX = 2;
var tenthY = 2.655;


console.log(checkIfInCircle(firstX, firstY));
console.log(checkIfInCircle(secondX, secondY));
console.log(checkIfInCircle(thirdX, thirdY));
console.log(checkIfInCircle(fourthX, fourthY));
console.log(checkIfInCircle(fifthX, fifthY));
console.log(checkIfInCircle(sixthX, sixthY));
console.log(checkIfInCircle(seventhX, seventhY));
console.log(checkIfInCircle(eighthX, eighthY));
console.log(checkIfInCircle(ninthX, ninthY));
console.log(checkIfInCircle(tenthX, tenthY));

function checkIfInCircle(x, y) {
    return Math.pow((x - centerX), 2) + Math.pow((y - centerY), 2) < Math.pow(radius, 2);
}