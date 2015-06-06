/*
 Write a JavaScript function to check if in a given expression the brackets are put correctly.
 Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
 */

function secondProblem(){
    var input = document.getElementById('bracketsInput').value,
        result = document.getElementById('bracketsOutputAnswer');

    var isInputCorrect = bracketsCheck(input);
    result.innerHTML = '';

    if(isInputCorrect){
        result.innerHTML += 'Bracket expression is CORRECT!';
        console.log('Bracket expression is CORRECT!');
    }
    else {
        result.innerHTML += 'Brackets expression is INCORRECT';
        console.log('Brackets expression is INCORRECT');
    }
}

function bracketsCheck(input){
    var leftBracketCounter = 0,
        rightBracketCounter = 0,
        index;

    if(input[0] == ')'|| input[input.length - 1] == '('){
        return false;
    }

    for(index = 0; index < input.length; index += 1){
        if(input[index] == '('){
            leftBracketCounter += 1;
        }
        else if(input[index] == ')'){
            rightBracketCounter += 1;
        }
    }

    if(rightBracketCounter != leftBracketCounter){
        return false;
    }

    return true;
}