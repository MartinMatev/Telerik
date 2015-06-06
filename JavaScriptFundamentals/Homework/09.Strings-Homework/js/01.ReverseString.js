/*
 Problem 1. Reverse string

 Write a JavaScript function that reverses a string and returns it.
 Example:

 input	output
 sample	elpmas
 */

function firstProblem(){
    var inputString = document.getElementById('reverseString').value,
        result = document.getElementById('reversedStringAnswer'),
        reversedString;

    result.innerHTML = '';
    reversedString = reverseString(inputString);
    result.innerHTML += 'Reversed string: ' + reversedString;
    console.log('Reversed string: ' + reversedString);

}

function reverseString(str){
    return str.split("").reverse().join("");
}