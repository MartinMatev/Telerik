/*
 Problem 7. First larger than neighbours

 Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
 Use the function from the previous exercise.
 */

function seventhProblem(){
    var inputSequence = document.getElementById('inputSequence').value;
    var result = document.getElementById('firstLargerAnswer');
    result.innerHTML = '';

    if(inputSequence === '' || !inputSequence.match(/\S/)){
        result.innerHTML += 'Wrong data input!';
    }
    else{
        var arr = inputSequence.split(', ');
        var answer =checkIndices(arr);
        result.innerHTML += 'The INDEX of first element that is  bigger than it\'s neighbours is ' + answer;
        console.log('The INDEX of first element that is  bigger than it\'s neighbours is ' + answer);
    }
}

function checkIndices(arr){
    var i;
    for(i = 1; i <= arr.length - 1; i += 1){
        console.log(i);
        if (isBigger(arr, i)){
            return i;
        }
    }

    return -1;
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