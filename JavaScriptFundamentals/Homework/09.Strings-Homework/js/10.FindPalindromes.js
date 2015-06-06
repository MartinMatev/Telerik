/*
 Problem 10. Find palindromes

 Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
 */

function tenthProblem(){
    var input = document.getElementById('palindromesText').value,
        result = document.getElementById('palindromesExtractedAnswer');

    result.innerHTML = '';
    var answer = input.match(/\w+/g).filter(function(word) {
        return checkIfPalindrome(word);
    });

    result.innerHTML += answer + ' ';
    console.log(answer);
}

function checkIfPalindrome(input){
    var i;

    for (i = 0; i < parseInt(input.length / 2, 10); i++)
        if (input[i] !== input[input.length - 1 - i]){
            return false;
        }
    return true;
}