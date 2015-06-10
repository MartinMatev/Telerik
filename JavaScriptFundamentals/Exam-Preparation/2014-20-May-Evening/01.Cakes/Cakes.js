function solve(params) {
    var totalMoney = Number(params[0]),
        cakeOne = Number(params[1]),
        cakeTwo = Number(params[2]),
        cakeThree = Number(params[3]);
    var answer = 0;
    // Your solution here

    for(var i = 0; i <= totalMoney; i += cakeOne){
        for(var j = 0; j <= totalMoney; j += cakeTwo){
            for(var k = 0; k <= totalMoney; k += cakeThree){
                if((i + j + k) <= totalMoney && (i + j + k) >= answer){
                    answer = (i + j + k);
                }
            }
        }
    }

    return answer;
}

var testOne = [
    '110',
    '13',
    '15',
    '17'
];

var testTwo = [
    '20',
    '11',
    '200',
    '300'
];

var testThree = [
    '110',
    '19',
    '29',
    '39'
];

solve(testOne);
solve(testTwo);
solve(testThree);
