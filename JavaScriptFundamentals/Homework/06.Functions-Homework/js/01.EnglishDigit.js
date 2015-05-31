/*
 Problem 1. English digit

 Write a function that returns the last digit of given integer as an English word.
 Examples:

 input	output
 512	two
 1024	four
 12309	nine
 */

function firstProblem(){
    var input = document.getElementById('convertToWord').value;
    var result = document.getElementById('convertToWordAnswer');
    result.innerHTML = '';

    if(input === '' || !input.match(/\S/) || isNaN(input)){
        result.innerHTML += 'Input cannot be empty or NaN!';
        console.log('Input cannot be empty or NaN!');
    }
    else{
        if(input < 0)   input*= -1;
        var digit = Math.floor(Number(input)) % 10;
        result.innerHTML += digit + ' = ' + generateWord(digit);
        console.log(digit + ' = ' + generateWord(digit));
    }
}

function generateWord(digit){
    switch (digit){
        case 1: return 'One';
        case 2: return 'Two';
        case 3: return 'Three';
        case 4: return 'Four';
        case 5: return 'Five';
        case 6: return 'Six';
        case 7: return 'Seven';
        case 8: return 'Eight';
        case 9: return 'Nine';
        default: return 'Zero';
    }
}