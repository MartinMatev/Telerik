function Solve(input){
    var result = 1;
    input = input.map(Number);

    for(var i = 2; i < input.length; i += 1){
        if(input[i -1] > input[i]){
            result++;
        }
    }

    return result;
}
