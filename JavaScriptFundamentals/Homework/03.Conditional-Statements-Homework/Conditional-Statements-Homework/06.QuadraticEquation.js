/*
    COPY PASTE THE FOLLOWING CODE IN THE BROWSER'S CONSOLE ! 
*/

/*
Problem 6. Quadratic equation

Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
Calculates and prints its real roots.
Note: Quadratic equations may have 0, 1 or 2 real roots.

	Examples:

a		b	c		roots
2		5	-3		x1= -3; x2= 0.5
-1		3	0		x1= 3; x2= 0
-0.5	4	-8		x1=x2= 4
5		2	8		no real roots
*/

console.log(quadraticEquation(2, 5, -3));
console.log(quadraticEquation(-1, 3, 0));
console.log(quadraticEquation(-0.5, 4, -8));
console.log(quadraticEquation(5, 2, 8));

function quadraticEquation(a, b, c) {
	var D = b * b - 4 * a * c;
	if (D < 0) {
		return 'no real roots';
	}
	else if (!D) {
		return getRoots(-1, D, b, a);
	}
	else {
		return [getRoots(-1, D, b, a), getRoots(1, D, b, a)];
	}
}

function getRoots(sign, D, b, a) {
	return (-b + Math.sqrt(D) * sign) / (2 * a);
}