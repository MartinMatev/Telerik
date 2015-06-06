/*
 Problem 9. Extract e-mails

 Write a function for extracting all email addresses from given text.
 All sub-strings that match the format @… should be recognized as emails.
 Return the emails as array of strings.
 */

function ninthProblem(){
    var input = document.getElementById('emailText').value,
        result = document.getElementById('emailTextExtractedAnswer'),
        display = document.getElementById('display');

    var answer = extractEmails(input);

    display.innerHTML = '';
    result.innerHTML = '';
    display.innerHTML += 'Original text: ' + '<br/>' + input;
    result.innerHTML += 'Extracted e-mails: ' + '<br/>' + answer;
    console.log(answer);
}

function extractEmails(text){
    return text.match(/\w+@\w+\.\w+/g);
}