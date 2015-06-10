function solve(input){
    var rowsCols = input[0].split(' ');
    var bounds = {
        rows: +rowsCols[0],
        cols: +rowsCols[1]
    }
    var matrix = input.splice(1).map(function (line) {
        // 'dr dl dr ur ul'
        // ->
        // ['dr', 'dl', 'dr', 'ur', 'ul']
       return line.split(' ');
    });

    var row = 0;
    var col = 0;
    var sum = 0;
    var dir;
    var deltas = {
        u: -1,
        d: +1,
        l: -1,
        r: +1
    };
    var leftRight;
    var upDown;

    while(true){
        if(row < 0 || row > bounds.rows ||
            col < 0 || col > bounds.cols){
            return 'successed with ' + sum;
        }

        if(matrix[row][col] == 'used'){
            return 'failed at (' + row + ',' + col + ')';
        }


        // update sum
        //sum += (1 << row) + col;
        sum += Math.pow(2, row) + col;

        dir = matrix[row][col];
        matrix[row][col] = 'used';
        upDown = dir[0];
        leftRight = dir[1];

        // update row
        row += deltas[upDown];

        // update col
        col += deltas[leftRight];
    }

    return matrix;
}

successTest =[
    '3 5',
    'dr dl dr ur ul',
    'dr dr ul ur ur',
    'dl dr ur dl ur'
];

failTest = [
    '3 5',
    'dr dl dl ur ul',
    'dr dr ul ul ur',
    'dl dr ur dl ur'
];

console.log(solve(successTest));
console.log(solve(failTest));
