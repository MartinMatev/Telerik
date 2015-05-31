/*
 Problem 6. Larger than neighbours

 Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).
 */

function sixthProblem(){
    var inputSequence = document.getElementById('inputArraySequence').value;
    var inputIndex = document.getElementById('inputIndex').value;
    var result = document.getElementById('neighboursCheckAnswer');
    result.innerHTML = '';

    if(inputSequence === '' || !inputSequence.match(/\S/) || inputIndex === '' || !inputIndex.match(/\S/)){
        result.innerHTML += 'Wrong data input!';
    }
    else{
        var arr = inputSequence.split(', ');
        var answer = isBigger(arr, inputIndex);
        result.innerHTML += 'Is the element ' + arr[inputIndex] + ' bigger than it\'s neighbours? - ' + answer;
        console.log('Is the element ' + arr[inputIndex] + ' bigger than it\'s neighbours? - ' + answer);
    }
}

function isBigger(arr, inputIndex){
    var isBigger = true;
    var currentIndex;

    for (currentIndex = inputIndex - 1; currentIndex <= inputIndex + 1; currentIndex += 2) {
        if (currentIndex >= 0 && currentIndex < arr.length) {
            if (arr[currentIndex] >= arr[inputIndex]) {
                isBigger = false;
                break;
            }
        }
    }

    return isBigger;
}