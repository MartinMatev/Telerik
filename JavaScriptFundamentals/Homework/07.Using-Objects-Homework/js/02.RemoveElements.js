/*
 Problem 2. Remove elements

 Write a function that removes all elements with a given value.
 Attach it to the array type.
 Read about prototype and how to attach methods.

 var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
 arr.remove(1); //arr = [2,4,3,4,111,3,2,'1'];
 */

function secondProblem(){
    var inputArray = document.getElementById('inputArray').value;
    var inputElement = document.getElementById('inputNumber').value;
    var result = document.getElementById('removeNumberAnswer');
    result.innerHTML = '';

    if(inputArray === '' || !inputArray.match(/\S/) || inputElement === '' || !inputElement.match(/\S/)){
        result.innerHTML += 'Wrong data input!';
        console.log('Wrong input data!');
    }
    else {
        var element;
        var arr = inputArray.split(', ');
        arr.remove(inputElement);

        result.innerHTML += 'After the removal of element ' + '\'' + inputElement + '\'' + ' the array looks like this: ' + arr;
        console.log('After the removal of element ' + '\'' + inputElement + '\'' + ' the array looks like this: ' + arr);
    }
}

Array.prototype.remove = function () {
    var currentElement,
        arg = arguments,
        len = arg.length,
        index;
    console.log(arguments);
    while(len && this.length){
        currentElement = arg[--len];
        while((index = this.indexOf(currentElement)) !== -1){
            this.splice(index, 1);
        }
    }
}