function solve(input){
    var wheels = parseInt(input[0]);
    var motor = 3;
    var car = 4;
    var truck = 10;
    var count = 0;

    for(var i = 0;i <= wheels; i += motor){
        for(var j = 0; j <= wheels; j += car){
            for(var k = 0; k <= wheels; k += truck){
                if((i + j + k) === wheels){
                    count++;
                }
            }
        }
    }

    return count;
}

var testOne = 7;
var testTwo = 10;
var testThree = 40;

console.log(solve(testOne));
console.log(solve(testTwo));
console.log(solve(testThree));