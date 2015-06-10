function Solve(input){
    var intArray = input.slice(1).slice().map(Number);
    //var numbers = [];
    //for(var i = 1; i < numbers.length; i += 1){
    //    numbers.push(parseInt(input[i]));
    //}

    var bestSum = intArray[0];
    for(var i = 0; i < intArray.length; i += 1){
        var currentSum = 0;
        for(var j = i; j < intArray.length; j += 1){
            currentSum += intArray[j];
            if (currentSum > bestSum){
                bestSum = currentSum;
            }
        }
    }

    return bestSum;
}

var testInput = [
    '8',
    '1',
    '6',
    '-9',
    '4',
    '4',
    '-2',
    '10',
    '-1'
];

console.log(Solve(testInput));