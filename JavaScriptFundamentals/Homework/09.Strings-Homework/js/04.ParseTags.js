/*
 Problem 4. Parse tags

 You are given a text. Write a function that changes the text in all regions:

 <upcase>text</upcase> to uppercase.
 <lowcase>text</lowcase> to lowercase
 <mixcase>text</mixcase> to mix casing(random)
 Example: We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.

 The expected result:
 We are LiVinG in a YELLOW SUBMARINE. We dOn'T have anything else.
 */

// Assign the variables outside of functions, so they become GLOBAL instead
var upCase = '<upcase>',
    upCaseEnd = '</upcase>',
    lowCase = '<lowcase>',
    lowCaseEnd = '</lowcase>',
    mixCase = '<mixcase>',
    mixCaseEnd = '</mixcase>',
    index,
    res = '',
    upCaseCheck = false,
    tempRes = '';

function fourthProblem(){
    var textInput = document.getElementById('inputText').value,
        result = document.getElementById('correctTransformationAnswer');

    result.innerHTML = '';
    res = '';
    var answer = tagChecker(textInput);

    result.innerHTML += answer;
}

function tagChecker(text){

    for(index = 0; index < text.length; index += 1){
        upCaseCheck = false;
        tempRes = '';

        if(text[index] == '<' && text.substr(index, upCase.length) == upCase){
            index = transformText(index, text, upCase, upCaseEnd, 'up');
        }
        else if(text[index] == '<' && text.substr(index, lowCase.length) == lowCase){
            index = transformText(index, text, lowCase, lowCaseEnd, 'low');
        }
        else if(text[index] == '<' && text.substr(index, mixCase.length) == mixCase){
            index = transformText(index, text, mixCase, mixCaseEnd, 'mix');
        }


        if(upCaseCheck){
            continue;
        }
        res += text[index];
    }

    return res;
}

function transformText(index, text, openingTag, closingTag, tag){
    var currentIndex = index + openingTag.length // Make the index point right AFTER <upcase>

    while(text[currentIndex] != '<'){
        tempRes += text[currentIndex];
        currentIndex += 1;
    }

    // Check if we are at an opening tag '<' and the substring, starting from that tag is </upcase>
    if(text[currentIndex] == '<' && text.substr(currentIndex, closingTag.length) == closingTag){
        upCaseCheck = true;
        if (tag == 'up') {
            res += tempRes.toUpperCase();
        }
        else if(tag == 'low'){
            res += tempRes.toLowerCase();
        }
        else if(tag =='mix'){
            for(var i = 0; i < tempRes.length; i += 1){
                var random = Math.floor((Math.random()*2)+1);

                if(random % 2 == 0){
                    res += tempRes[i].toUpperCase();
                }
                else{
                    res += tempRes[i].toLowerCase();
                }
            }
        }
        index = currentIndex + closingTag.length - 1; // Assigning the first index AFTER </upcase> as the new `i`
    }

    return index;
}