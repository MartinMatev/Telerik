function Solve(input){
    var rowsColsAndJumps = parseNumbers(input[0]),
        startPosition = parseNumbers(input[1]);

    var rows = rowsColsAndJumps[0],
        cols = rowsColsAndJumps[1],
        allJumps = rowsColsAndJumps[2],
        currentRow = startPosition[0],
        currentCol = startPosition[1],
        counter = 1,
        field = initField(),
        jumps = readJumps(),
        jumpsIndex = 0,
        escaped = false,
        sumOfNumbers = 0,
        totalJumps = 0;

    while(true){
        if(currentRow < 0 || currentRow >= rows
            || currentCol < 0 || currentCol >= cols){
            escaped = true;
            break;
        }

        if(field[currentRow][currentCol] === 'X'){
            escaped = false;
            break;
        }

        sumOfNumbers += field[currentRow][currentCol];
        totalJumps++;

        var currentJump = jumps[jumpsIndex++];
        if(jumpsIndex >= jumps.length){
            jumpsIndex = 0;
        }
        field[currentRow][currentCol] = 'X';

        currentRow += currentJump.row;
        currentCol += currentJump.col;
    }

    return escaped ? 'escaped ' + sumOfNumbers : 'caught ' + totalJumps;

    function initField(){
        var field = [];
        for(var i = 0; i < rows; i += 1){
            field[i] = [];

            for(var j = 0; j < cols;j += 1){
                field[i][j] = counter++;
            }
        }

        return field;
    }


    function readJumps(){
        var jumps = [];
        for(var i = 2; i < 2 + allJumps;i += 1){
            var parsedJump = parseNumbers(input[i]);
            var currentJump = {
                row: parsedJump[0],
                col: parsedJump[1]
            };
            jumps.push(currentJump);
        }

        return jumps;
    }

    function parseNumbers(input){
        return input.split(' ').map(Number);
    }
}

var input = [
    '6 7 3',
    '0 0',
    '2 2',
    '-2 2',
    '3 -1'
];

console.log(Solve(input));
