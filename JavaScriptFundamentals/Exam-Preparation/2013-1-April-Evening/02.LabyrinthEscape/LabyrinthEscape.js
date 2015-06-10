function solve(input){
    var sizes = input[0].split(' '),
        rows = parseInt(sizes[0]),
        cols = parseFloat(sizes[1]),
        startPosition = input[1].split(' '),
        row = parseInt(startPosition[0]),
        col = parseInt(startPosition[1]),
        lab = input.slice(2),
        visited = {},
        count = 0,
        sum = 0,
        directions = {
            u: {
                row: -1,
                col: 0
            },
            d: {
                row: +1,
                col: 0
            },
            l: {
                row: 0,
                col: -1
            },
            r: {
                row: 0,
                col: +1
            }
        }



    while(true){
        // check if outside the labyrinth
        if(!inRange(row, rows) || !inRange(col, cols)){
            return 'out ' + sum;
        }

        var cellValue = getValueAt(row, col, cols);
        if(visited[cellValue]){
            return 'lost ' + count;
        }
        sum += cellValue;
        count++;
        visited[getValueAt(row, col, cols)] = true;

        var dir = lab[row][col];
        row += directions[dir].row;
        col += directions[dir].col;
    }

    function getValueAt(row, col, cols){
        return row * cols + col + 1;
    }

    function inRange(value, border){
        return 0 <= value && value < border;
    }
}

var testInput = [
    "3 4",
    "1 3",
    "lrrd",
    "dlll",
    "rddd"
];

console.log(solve(testInput));