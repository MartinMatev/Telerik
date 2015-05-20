/*
    COPY PASTE THE FOLLOWING CODE IN THE BROWSER'S CONSOLE ! 
*/

/*
Problem 9. Point in Circle and outside Rectangle

Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
Examples:

x	    y	    inside K & outside of R
1	    2	    yes
2.5	    2	    no
0	    1	    no
2.5	    1	    no
2	    0	    no
4	    0	    no
2.5	    1.5	    no
2	    1.5	    yes
1	    2.5	    yes
-100    -100	no
*/

var centerX = 1;
var centerY = 1;
var radius = 3;

var firstPoint = [1, 2];
var secondPoint = [2.5, 2];
var thirdPoint = [0, 1];
var fourthPoint = [2.5, 1];
var fifthPoint = [2, 0];
var sixthPoint = [4, 0];
var seventhPoint = [2.5, 1.5];
var eighthPoint = [2, 1.5];
var ninthPoint = [1, 2.5];
var tenthPoint = [-100, -100];

console.log((checkIfInCircle(firstPoint[0], firstPoint[1]) &&
            checkIfOutsideRectangle(firstPoint[0], firstPoint[1])) ? "yes" : "no");
console.log((checkIfInCircle(secondPoint[0], secondPoint[1]) &&
            checkIfOutsideRectangle(secondPoint[0], secondPoint[1])) ? "yes" : "no");
console.log((checkIfInCircle(thirdPoint[0], thirdPoint[1]) &&
            checkIfOutsideRectangle(thirdPoint[0], thirdPoint[1])) ? "yes" : "no");
console.log((checkIfInCircle(fourthPoint[0], fourthPoint[1]) &&
            checkIfOutsideRectangle(fourthPoint[0], fourthPoint[1])) ? "yes" : "no");
console.log((checkIfInCircle(fifthPoint[0], fifthPoint[1]) &&
            checkIfOutsideRectangle(fifthPoint[0], fifthPoint[1])) ? "yes" : "no");
console.log((checkIfInCircle(sixthPoint[0], sixthPoint[1]) &&
            checkIfOutsideRectangle(sixthPoint[0], sixthPoint[1])) ? "yes" : "no");
console.log((checkIfInCircle(seventhPoint[0], seventhPoint[1]) &&
            checkIfOutsideRectangle(seventhPoint[0], seventhPoint[1])) ? "yes" : "no");
console.log((checkIfInCircle(eighthPoint[0], eighthPoint[1]) &&
            checkIfOutsideRectangle(eighthPoint[0], eighthPoint[1])) ? "yes" : "no");
console.log((checkIfInCircle(ninthPoint[0], ninthPoint[1]) &&
            checkIfOutsideRectangle(ninthPoint[0], ninthPoint[1])) ? "yes" : "no");
console.log((checkIfInCircle(tenthPoint[0], tenthPoint[1]) &&
            checkIfOutsideRectangle(tenthPoint[0], tenthPoint[1])) ? "yes" : "no");


function checkIfInCircle(x, y) {
    return Math.pow((x - centerX), 2) + Math.pow((y - centerY), 2) < Math.pow(radius, 2);
}

function checkIfOutsideRectangle(x, y) {
    return !((x >= -1 && x <= -1 + 6) && (y <= 1 && y >= 1 - 2));
}