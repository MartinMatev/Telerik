/*
 Problem 5. Selection sort

 Sorting an array means to arrange its elements in increasing order.
 Write a script to sort an array.
 Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
 Hint: Use a second array
 */

function fifthProblem(){
    var input = document.getElementById('inputArrayToSort').value;
    var result = document.getElementById('fifthAnswer');

    // Check if the input is empty or contains only whitespaces
    if(input === '' || !input.match(/\S/)){
        result.innerHTML = 'Input cannot be empty!';
        return;
    } else {
        result.innerHTML = '';
        var numbersArray = input.split(', ');

        // Initialize the first array digit as the min value
        for (var index = 0; index < numbersArray.length; index++)
        {
            var swapCheck = false;
            var minDigitIndex = index;
            for (var nextIndex = index + 1; nextIndex < numbersArray.length; nextIndex++)
            {
                if (Number(numbersArray[nextIndex]) < Number(numbersArray[minDigitIndex]))
                {
                    minDigitIndex = nextIndex;
                    swapCheck = true;
                }
            }
            if (swapCheck)
            {
                // Call the Swap method, with the array and the 2 positions which values to swap
                SwapArrayValues(numbersArray, index, minDigitIndex);
            }
        }

        console.log("The sorted array: " + numbersArray);
        result.innerHTML += numbersArray;
    }
}

function SwapArrayValues(array, positionOne, positionTwo)
{
    var temp = array[positionOne];
    array[positionOne] = array[positionTwo];
    array[positionTwo] = temp;
}