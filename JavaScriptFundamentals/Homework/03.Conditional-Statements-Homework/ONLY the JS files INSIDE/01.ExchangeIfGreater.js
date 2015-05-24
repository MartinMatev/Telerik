/*
    COPY PASTE THE FOLLOWING CODE IN THE BROWSER'S CONSOLE ! 
*/

/*
Problem 1. Exchange if greater

Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
As a result print the values a and b, separated by a space.
Examples:

a		b		result
5		2		2 5
3		4		3 4
5.5		4.5		4.5 5.5
*/

var firstA = 5;
var firstB = 2;

var secondA = 3;
var secondB = 4;

var thirdA = 5.5;
var thirdB = 4.5;

findGreater(firstA, firstB);
findGreater(secondA, secondB);
findGreater(thirdA, thirdB);

function findGreater(a, b) {
	if (a > b)
	{
		var temp = a;
		a = b;
		b = temp;

		console.log("Values of 'a' and 'b'!")
	}
	console.log(a + " " + b);
}