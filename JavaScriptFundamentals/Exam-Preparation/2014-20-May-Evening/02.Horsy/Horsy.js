function solve(input){
    var rowsAndCols = input[0].split(' ').map(Number);
    var rows = rowsAndCols[0];
    var cols = rowsAndCols[1];
    var row = rows - 1;
    var col =  cols - 1;
    var moves = [
        [-2, 1],
        [-1, 2],
        [1, 2],
        [2, 1],
        [2, -1],
        [1, -2],
        [-1, -2],
        [-2, -1]
    ];

    var pointsSum = 0;
    var moveCount = 0;
    var used = [];

    while(true){
        // out of the play field
        if (row < 0 || row >= rows
        || col < 0 || col >= cols){
            return 'Go go Horsy! Collected ' + pointsSum + ' weeds';
        }

        if(used[row + ' ' + col]){
            return 'Sadly the horse is doomed in ' + moveCount + ' jumps';
        }

        moveCount += 1;
        pointsSum += getPoints(row, col);

        var move = moves[getValue(input, row, col) - 1];

        used[row + ' ' + col] = true;
        row += move[0];
        col += move[1];
    }

    function getPoints(row, col){

        return Math.pow(2, row) - col;
    }

    function getValue(input, row, col){

        return input[row + 1][col];
    }
}

argsOne = [
    '3 5',
    '54561',
    '43328',
    '52388'
];

argsTwo = [
    '3 5',
    '54361',
    '43326',
    '52188'
];

console.log(solve(argsOne));
console.log(solve(argsTwo));
