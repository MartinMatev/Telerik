/**
 * Created by Matev on 5/25/2015.
 */

/*
 Problem 2. Lexicographically comparison

 Write a script that compares two char arrays lexicographically (letter by letter).
 */

function secondProblem(){
    var firstInput = document.getElementById('firstInputArray').value;
    var secondInput = document.getElementById('secondInputArray').value;
    var result = document.getElementById('secondAnswer');

    // Check if the input is empty or contains only whitespaces
    if(firstInput === '' || secondInput === '' || !firstInput.match(/\S/) || !secondInput.match(/\S/)){
        result.innerHTML = 'Input cannot be empty!';
        return;
    } else{
        result.innerHTML = '';
        firstInput = firstInput.split(', ');
        secondInput = secondInput.split(', ');
        var lesserLength = Math.min(firstInput.length, secondInput.length);
        var lexicographicallyFirst = firstInput;

        for (var i = 0; i < lesserLength; i++)
        {
            // If a letter in the second word is before it's counterpart (lexicographically)
            if (firstInput[i] > secondInput[i])
            {
                lexicographicallyFirst = secondInput;
                break;
            }
        }

        lexicographicallyFirst = lexicographicallyFirst.join(', ');
        result.innerHTML += lexicographicallyFirst;
        console.log('Lexicographically first is: ' + lexicographicallyFirst);
    }
}