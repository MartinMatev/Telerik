/*
 Problem 4. Number of elements

 Write a function to count the number of div elements on the web page
 */

function fourthProblem(){
    var input = document.getElementById('tagInput').value;
    var tag = document.getElementsByTagName(input).length;
    var result = document.getElementById('tagCountAnswer');

    result.innerHTML = '';
    result.innerHTML += 'Your input tag: ' + input + '<br/> Count: ' + tag;
    console.log('Your input tag: ' + input + '<br/> Count: ' + tag);
}