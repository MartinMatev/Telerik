// NOT WORKING AS INTENDED ! IDGAF

function Solve(input){
    var finalResult;

    for(var i = 0; i < input.length; i += 1){
        var currentRow = input[i].trim();

        var operator = '';
        var nestedOperator = '';
        var currentDigit = '';
        var parameters = [];
        var nestedParams = [];

        var inCommand = false;
        var inNestedCommand = false;

        for(var j = 0; j < currentRow.length; j += 1){
            var currentSymbol = currentRow[j];

            if(currentSymbol == ' ' || currentSymbol == ')'){

                if(currentDigit !== ''){
                    if(inNestedCommand){
                        nestedParams.push(parseInt(currentDigit));
                    }
                    else{
                        parameters.push(parseInt(currentDigit));
                        currentDigit = '';
                    }
                }

                if(inNestedCommand && currentSymbol == ')'){
                    var nestedResult = calculate(nestedOperator, nestedParams);
                    parameters.push(nestedResult);

                    nestedParams = [];
                    nestedOperator = '';
                    inNestedCommand = false;
                }

                continue;
            }

            if(currentSymbol == '('){
                if(inCommand){
                    inNestedCommand = true;
                }
                else{
                    inCommand = true;
                }

                continue;
            }

            if(isMathOperator(currentSymbol)){
                if(currentSymbol == '-'
                    && j + 1 < currentRow.length
                    && isNumber(currentRow[j + 1])){
                    currentDigit += currentSymbol;
                }
                else{
                    if(inNestedCommand){
                        nestedOperator = currentSymbol;
                    }
                    else{
                        operator = currentSymbol;
                    }
                }

                continue;
            }

            if(isNumber(currentSymbol)){
                currentDigit += currentSymbol;
                continue;
            }
        }

        finalResult = calculate(operator, parameters);
        if(finalResult == 'Error'){
            return 'Division by zero! At Line:' + (i + 1);
        }
    }

    return finalResult;

    function isMathOperator(symbol){
        if(symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/'){
            return true;
        }

        return false;
    }

    function isNumber(symbol){
        if(symbol == ' '){
            return false;
        }

        return symbol == Number(symbol);
    }

    function calculate(operator, parameters){
        if(parameters.length == 1){
            return parameters[0];
        }

        var result = parameters[0];
        for(var i = 1; i < parameters.length; i += 1){
            switch (operator){
                case '-': result -= parameters[i]; break;
                case '+': result += parameters[i]; break;
                case '*': result *= parameters[i]; break;
                case '/':
                    if(parameters[i] == 0){
                        return 'Error';
                    }

                    result /= parameters[i];
                    result = parseInt(result);
                    break;
            }
        }

        return result;
    }
}

var firstTest = [
    '(+ 1 2 (* 1 1 1 1) 7)',
    //'(+ 50 2 7 1)',
    //'(- 42 2)',
    //'(- 4)',
    //'(/ 2)',
    //'(/ 10 3)',
    //'(/ 10 3 2)'
];
var secondTest = [
    '(def myFunc 5)',
'(def myNewFunc (+  myFunc  myFunc 2))',
'(def MyFunc (* 2  myNewFunc))',
'(/   MyFunc  myFunc)'

];
var thirdTest = [
    '(def func 10)',
'(def newFunc (+  func 2))',
'(def sumFunc (+ func func newFunc 0 0 0))',
'(* sumFunc 2)',

];
var fourthTest = [
    '(def func (+ 5 2))',
'(def func2 (/  func 5 2 1 0))',
'(def func3 (/ func 2))',
'(+ func3 func)',

];

console.log(Solve(firstTest));
//console.log(Solve(secondTest));
//console.log(Solve(thirdTest));
//console.log(Solve(fourthTest));