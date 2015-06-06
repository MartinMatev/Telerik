/*
 Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).
 Example:

 The target sub-string is in

 The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

 The result is: 9
 */

function thirdProblem(){
    var textInput = document.getElementById('textInput').value,
        keyWord = document.getElementById('subStringInput').value,
        result = document.getElementById('searchResultsAnswer');

    var subStrCount = countSubStrings(keyWord, textInput);
    result.innerHTML = '';
    result.innerHTML += "Total count: " + subStrCount;
    console.log("Total count: " + subStrCount);
}

function countSubStrings(keyWord, text){
    var regex = new RegExp(keyWord, 'gi');
    return (text.match(regex).length);
}