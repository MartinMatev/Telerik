/*
Problem 4. Maximal increasing sequence

Write a script that finds the maximal increasing sequence in an array.
    Example:

input	result
3, 2, 3, 4, 2, 2, 4	2, 3, 4
*/

/*
 WORK WITH CHARS AND STRINGS AS WELL !
 */
function fourthProblem(){
    var input = document.getElementById('inputSequence').value;
    var result = document.getElementById('fourthAnswer');

    // Check if the input is empty or contains only whitespaces
    if(input === '' || !input.match(/\S/)){
        result.innerHTML = 'Input cannot be empty!';
        return;
    } else{
        var numbersArray = input.split(', ');
        var maxSequence = 0;
        var biggestSequence = new Array();
        var temporarySequence = new Array();
        result.innerHTML = '';

        for (var index = 0; index < numbersArray.length; index++)
        {
            var sequenceCounter = 0;
            var currentSequence = 0;
            temporarySequence = [];

            for (var nextIndex = index + 1; nextIndex < numbersArray.length; nextIndex++)
            {
                // Checks if the next number is BIGGER than the previous (Bigger as in not + 1, but bigger in general (+ 2, + 5 etc.))
                if (numbersArray[index + sequenceCounter] < numbersArray[nextIndex])
                {
                    // If so, current sequence counter goes up by 1 and the element is added to the temporary sequence list
                    currentSequence++;
                    temporarySequence.push(numbersArray[nextIndex]);
                }
                else
                {
                    break;
                }
                // the sequence counter goes up by 1 after every turn, so we add it to the current index and take the next element
                sequenceCounter++;
            }
            // If the current sequence is equal or greater, initialize the maxSequence with its value,
            //initialize the "startingSequenceNumber" with first element of the sequence, and move the sequence MEMBERS from the temp list, to the actual one.
            if (currentSequence >= maxSequence)
            {
                maxSequence = currentSequence;
                biggestSequence = temporarySequence.slice();
                biggestSequence.unshift(numbersArray[index])
            }
        }
        console.log('The biggest increasing sequence is: ' + biggestSequence);
        result.innerHTML += biggestSequence;
        result.innerHTML =  result.innerHTML.replace(/,\s*$/, "");
    }
}