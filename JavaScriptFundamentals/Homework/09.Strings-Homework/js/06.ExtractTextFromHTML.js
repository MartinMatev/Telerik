/*
 Problem 6. Extract text from HTML

 Write a function that extracts the content of a html page given as text.
 The function should return anything that is in a tag, without the tags.
 Example:

 <html>
 <head>
 <title>Sample site</title>
 </head>
 <body>
 <div>text
 <div>more text</div>
 and more...
 </div>
 in body
 </body>
 </html>
 Result: Sample sitetextmore textand more...in body
 */

function sixthProblem(){
    var htmlText = document.getElementById('extractInput').value,
        result = document.getElementById('extractedOutputAnswer');

    result.innerHTML = '';
    var answer = extractContent(htmlText);
    result.innerHTML += 'Text without the tags: ' + answer;
    console.log('Text without the tags: ' + answer);
}

function extractContent(text){
    var regex = /(<([^>]+)>)/ig,
        body = text;

    return body.replace(regex, '');
}