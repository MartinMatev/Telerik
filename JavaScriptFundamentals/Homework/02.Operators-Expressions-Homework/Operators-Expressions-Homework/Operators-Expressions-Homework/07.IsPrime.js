/*
    COPY PASTE THE FOLLOWING CODE IN THE BROWSER'S CONSOLE ! 
*/

/*
Problem 7. Is prime

Write an expression that checks if given positive integer number n (n ≤ 100) is prime.
Examples:

n	Prime?
1	false
2	true
3	true
4	false
9	false
37	true
97	true
51	false
-3	false
0	false
*/

var one = 1;
var two = 2;
var three = 3;
var four = 4;
var nine = 9;
var thirtySeven = 37;
var ninetySeven = 97;
var fiftyOne = 51;
var minusThree = -3;
var zero = 0;

console.log(checkIfPrime(one));
console.log(checkIfPrime(two));
console.log(checkIfPrime(three));
console.log(checkIfPrime(four));
console.log(checkIfPrime(nine));
console.log(checkIfPrime(thirtySeven));
console.log(checkIfPrime(ninetySeven));
console.log(checkIfPrime(fiftyOne));
console.log(checkIfPrime(minusThree));
console.log(checkIfPrime(zero));

function checkIfPrime(number) {
    var divider = 2;
    var maxDivider = Math.sqrt(number);
    var isPrime = number >= 2;

    while (isPrime && divider <= maxDivider) {
        if (number % divider == 0) {
            isPrime = false;
            break;
        }
        divider++;
    }

    return isPrime;
}