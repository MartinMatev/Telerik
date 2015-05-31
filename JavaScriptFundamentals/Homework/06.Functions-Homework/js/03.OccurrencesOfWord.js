/*
 Problem 3. Occurrences of word

 Write a function that finds all the occurrences of word in a text.
 The search can be case sensitive or case insensitive.
 Use function overloading.
 */

function thirdProblem(){
    var inputText = document.getElementById('inputText').value;
    var inputWord = document.getElementById('inputWord').value;
    var radios = document.getElementsByName('case');
    var result = document.getElementById('occurenceAnswer');
    result.innerHTML = '';

    if (inputText === '' || !inputText.match(/\S/) || inputWord === '' || !inputWord.match(/\S/)) {
        result.innerHTML += 'Input cannot be empty!';
        console.log('Input cannot be empty!');
    }
    else {
        var checkedValue = false;
        for(var i = 0; i < radios.length; i += 1){
            if (radios[i].checked){
                checkedValue = radios[i].value;
                break;
            }
        }

        var answer = countSubstring(inputText, inputWord, checkedValue);
        result.innerHTML += 'The search is Case-' + checkedValue + '<br/>' + 'The word ' + inputWord + ' is present ' + answer + ' times';
        console.log('The search is Case-' + checkedValue);
        console.log('The word ' + inputWord + ' is present ' + answer + ' times');
    }
}

function countSubstring(text, keyword, checkedValue){
    var regexString = '\\b' + keyword + '\\b';
    var modifier = checkedValue === 'sensitive' ? 'gm' : 'gim';
    var regex = new RegExp(regexString, modifier);

    return text.match(regex).length;
}