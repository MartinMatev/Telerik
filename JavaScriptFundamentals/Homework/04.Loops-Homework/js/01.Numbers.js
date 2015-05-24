
// Problem 1: Numbers

function firstProblem() {
    var inputNumber = document.getElementById('firstNumber').value;
    var result = document.getElementById('firstAnswer');
    var index;

    if (!isNaN(inputNumber) && inputNumber !== '' && inputNumber > 0) {      
        result.innerHTML = '';
        console.log('Numbers from 1 to  ' + inputNumber);

        for (index = 1; index <= inputNumber; index ++) {
            result.innerHTML += index + ', ';
            console.log(index);
        }
    } else {
         result.innerHTML =
            'Please make sure to type in a POSITIVE INTEGER, not w/e you just did put in the box.';
    }

    // Remove the last comma when the loop is over /using regex/
    result.innerHTML =  result.innerHTML.replace(/,\s*$/, "");
}