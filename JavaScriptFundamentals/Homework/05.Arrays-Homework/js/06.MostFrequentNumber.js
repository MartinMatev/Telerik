/*
 Problem 6. Most frequent number

 Write a script that finds the most frequent number in an array.
 Example:

 input	result
 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	4 (5 times)
 */

function sixthProblem(){
    var input = document.getElementById('inputFrequencyArray').value;
    var result = document.getElementById('sixthAnswer');

    // Check if the input is empty or contains only whitespaces
    if(input === '' || !input.match(/\S/)){
        result.innerHTML = 'Input cannot be empty!';
        return;
    } else {
        result.innerHTML = '';
        var numbersArray = input.split(', ');
        var mostFrequentNumber = 0;
        var finalFrequencyCounter = 0;
        console.log(typeof finalFrequencyCounter);

        for (var index = 0; index < numbersArray.length; index++)
        {
            var currentFrequencyCounter = 1;
            for (var nextIndex = index + 1; nextIndex < numbersArray.length; nextIndex++)
            {
                if (numbersArray[index] == numbersArray[nextIndex])
                {
                    currentFrequencyCounter++;
                }
            }

            if (currentFrequencyCounter > finalFrequencyCounter)
            {
                finalFrequencyCounter = currentFrequencyCounter;
                mostFrequentNumber = numbersArray[index];
            }
        }
        result.innerHTML += mostFrequentNumber + '(' + finalFrequencyCounter + ')';
        console.log("Most frequent number is: " + mostFrequentNumber + '(' + finalFrequencyCounter + ')');
    }
}