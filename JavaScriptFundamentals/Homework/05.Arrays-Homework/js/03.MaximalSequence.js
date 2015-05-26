/*
 Problem 3. Maximal sequence

 Write a script that finds the maximal sequence of equal elements in an array.
 Example:

 input	result
 2, 1, 1, 2, 3, 3, 2, 2, 2, 1	2, 2, 2
 */

/*
    WORK WITH CHARS AND STRINGS AS WELL !
*/

function thirdProblem(){
    var input = document.getElementById('inputArray').value;
    var result = document.getElementById('thirdAnswer');

    // Check if the input is empty or contains only whitespaces
    if(input === '' || !input.match(/\S/)){
        result.innerHTML = 'Input cannot be empty!';
        return;
    } else{
        var numbersArray = input.split(', ');
        var maxLength = 0;
        var maxSequence = '';
        var value;
        result.innerHTML = '';

        // Iterate through the array's ordered elements
        for (var i = 0; i < numbersArray.length; i++)
        {
            var currentLength = 1;
            // Iterate through the rest of the array's elements and check for matches
            for (var j = i + 1; j <= numbersArray.length - 1; j++)
            {
                if (numbersArray[i] == numbersArray[j])
                {
                    currentLength++;
                }
                else
                {
                    break;
                }
            }

            if (currentLength >= maxLength)
            {
                maxLength = currentLength;
                value = numbersArray[i];   // initialize "value" with the most repetitive array element
            }
        }

        for(var i = 0; i < maxLength; i++) {
            maxSequence += value + ', ';
        }
        console.log('The maximal sequence is: ' + maxSequence);
        result.innerHTML += maxSequence;
        result.innerHTML =  result.innerHTML.replace(/,\s*$/, "");
    }
}
