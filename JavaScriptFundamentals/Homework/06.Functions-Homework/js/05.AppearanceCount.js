/*
 Problem 5. Appearance count

 Write a function that counts how many times given number appears in given array.
 Write a test function to check if the function is working correctly.
 */

function fifthProblem(){
    var inputArray = document.getElementById('inputSearchArray').value;
    var inputElement = document.getElementById('inputSearchNumber').value;
    var result = document.getElementById('numberCountAnswer');
    result.innerHTML = '';

    if(inputArray === '' || !inputArray.match(/\S/) || inputElement === '' || !inputElement.match(/\S/)){
        result.innerHTML += 'Wrong data input!';
    }
    else{
        var counter = 0;
        var element;
        var arr = inputArray.split(', ');
        for(element = 0; element < arr.length; element += 1){
            if (arr[element] == inputElement){
                counter += 1;
            }
        }

        console.log('The numbers is found ' + counter + ' time/s in the input array.');
        result.innerHTML += 'The numbers is found ' + counter + ' time/s in the input array.';
    }
}