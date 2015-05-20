/*
    COPY PASTE THE FOLLOWING CODE IN THE BROWSER'S CONSOLE ! 
*/

/*
Problem 3. Rectangle area

Write an expression that calculates rectangle’s area by given width and height.
    Examples:

width	height	area
3	    4	    12
2.5	    3	    7.5
5	    5	    25
*/

var firstWidth = 3;
var firstHeight = 4;

var secondWidth = 2.5;
var secondHeight = 3;

var thirdWidth = 5;
var thirdHeight = 5;

console.log(findArea(firstWidth, firstHeight));
console.log(findArea(secondWidth, secondHeight));
console.log(findArea(thirdWidth, thirdHeight));

function findArea(width, height) {
    return width * height;
};