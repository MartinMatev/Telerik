/*
 Problem 11. String format

 Write a function that formats a string using placeholders.
 The function should work with up to 30 placeholders and all types.
 Examples:

 var str = stringFormat('Hello {0}!', 'Peter');
 //str = 'Hello Peter!';

 var frmt = '{0}, {1}, {0} text {2}';
 var str = stringFormat(frmt, 1, 'Pesho', 'Gosho');
 //str = '1, Pesho, 1 text Gosho'
 */

function eleventhProblem(){
    var result = document.getElementById('stringFormattedAnswer'),
        textArray = ['{0}, {1}! {2} {3} {4} {5} {6} {7} {8} !', 'Hello', 'World', 'I', 'would', 'like', 'you', 'to', 'go', 'away'];

    result.innerHTML = '';
    result.innerHTML += format('{0}, {1}! {2} {3} {4} {5} {6} {7} {8} !', 'Hello', 'World', 'I', 'would', 'like', 'you', 'to', 'go', 'away');
    console.log(format('{0}, {1}! {2} {3} {4} {5} {6} {7} {8} !', 'Hello', 'World', 'I', 'would', 'like', 'you', 'to', 'go', 'away'));
}

function format(text){
    // A variable that contains all the string arguments
    var selfArguments = arguments;

    return text.replace(/\{(\d+)}/g, function(match, element) {
    return selfArguments[+element + 1];
    })
}