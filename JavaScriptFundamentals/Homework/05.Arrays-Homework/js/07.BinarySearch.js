/*
 Problem 7. Binary search

 Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.
 */

function seventhProblem(){
    var inputArray = document.getElementById('inputBinarySearchArray').value;
    var inputNumber = document.getElementById('inputBinarySearchNumber').value;
    var result = document.getElementById('seventhAnswer');

    // Check if the input is empty or contains only whitespaces
    if(inputArray === '' || !inputArray.match(/\S/) || inputNumber === '' || !inputNumber.match(/\S/)){
     result.innerHTML = 'Input cannot be empty!';
     return;
    } else {
        result.innerHTML = '';
        var numbersArray = inputArray.split(', ');
        numbersArray.sort(function(a, b) {
            return a - b;
        });
        var searchedIndex = binarySearch(numbersArray, inputNumber);
        result.innerHTML += 'SORTED ARRAY: ' +numbersArray + '<br/>' + 'Index of the number you are searching for: ' + searchedIndex;
        console.log('SORTED ARRAY: ' +numbersArray);
        console.log('Index of the number you are searching for: ' + searchedIndex);
    }
}

function binarySearch(numbersArray, searchElement){
    var minIndex = 0;
    var maxIndex = numbersArray.length - 1;
    var currentIndex;
    var currentElement;

    while (minIndex <= maxIndex){
        currentIndex = (minIndex + maxIndex) / 2 | 0;
        currentElement = numbersArray[currentIndex];

        if (currentElement < searchElement){
            minIndex = currentIndex + 1;
        }
        else if (currentElement > searchElement){
            maxIndex = currentIndex - 1;
        }
        else {
            return currentIndex;
        }
    }

    return -1;
}