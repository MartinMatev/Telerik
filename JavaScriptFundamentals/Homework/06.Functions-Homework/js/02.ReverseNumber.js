/*
 Problem 2. Reverse number

 Write a function that reverses the digits of given decimal number.
 Example:

 input	output
 256	652
 123.45	54.321
 */

function secondProblem() {
    var input = document.getElementById('decimalNumber').value;
    var result = document.getElementById('decimalNumberAnswer');
    result.innerHTML = '';

    if (input === '' || !input.match(/\S/) || isNaN(input)) {
        result.innerHTML += 'Input cannot be empty or NaN!';
        console.log('Input cannot be empty or NaN!');
    }
    else {
        var answer = numberReverser(input);
        result.innerHTML += 'Reversed number = ' + answer;
        console.log('Reversed number = ' + answer);
    }
}

function numberReverser(input){
    var reversedNum = '';

    for(var i = input.length - 1; i >= 0; i--){
        reversedNum += input[i];
    }

    return reversedNum;
}