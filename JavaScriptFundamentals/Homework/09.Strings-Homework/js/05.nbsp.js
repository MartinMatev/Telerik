/*
 Problem 5. nbsp

 Write a function that replaces non breaking white-spaces in a text with &nbsp;
 */

function fifthProblem(){
    var input = document.getElementById('spaceText').value,
        result = document.getElementById('spaceReplacedAnswer');

    result.innerHTML = '';
    var answer = replaceWhiteSpace(input, '&nbsp;', ' ');
    result.innerHTML += 'Result is shown ONLY in the console, so press F12, choose the CONSOLE tab and inspect it.';
    console.log('Text with replaced white-spaces: ' + answer);
}

function replaceWhiteSpace(text, replacement, whiteSpace){
    var regex = new RegExp(whiteSpace, 'gi');
    return text.replace(regex, replacement);
}