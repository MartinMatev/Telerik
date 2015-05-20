/*
    COPY PASTE THE FOLLOWING CODE IN THE BROWSER'S CONSOLE ! 
*/

/*
Problem 5. Third bit

Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.
Examples:

n	    binary      representation	    bit #3
5	    00000000    00000101	        0
8	    00000000    00001000	        1
0	    00000000    00000000	        0
15	    00000000    00001111	        1
5343    00010100    11011111	        1
62241	11110011    00100001	        0
*/

var position = 3;
var first = 5;
var second = 8;
var third = 0;
var fourth = 15;
var fifth = 5343;
var sixth = 62241;

console.log("Bit #3 = " + getBit(first, position));
console.log("Bit #3 = " + getBit(second, position));
console.log("Bit #3 = " + getBit(third, position));
console.log("Bit #3 = " + getBit(fourth, position));
console.log("Bit #3 = " + getBit(fifth, position));
console.log("Bit #3 = " + getBit(sixth, position));

function getBit(number, position) {
    return (number >> position) & 1;
};