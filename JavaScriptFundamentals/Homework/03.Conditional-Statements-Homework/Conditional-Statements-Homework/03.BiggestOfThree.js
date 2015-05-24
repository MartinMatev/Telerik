/*
    COPY PASTE THE FOLLOWING CODE IN THE BROWSER'S CONSOLE ! 
*/

/*
Problem 3. The biggest of Three

Write a script that finds the biggest of three numbers.
Use nested if statements.
Examples:

a	    b	    c	    biggest
5	    2	    2	    5
-2	    -2	    1	    1
-2	    4	    3	    4
0	    -2.5    5	    5
-0.1    -0.5    -1.1    -0.1
*/

var firstSet = [5, 2, 2];
var secondSet = [-2, -2, 1];
var thirdSet = [-2, 4, 3];
var fourthSet = [0, -2.5, 5];
var fifthSet = [-0.1, -0.5, -1.1];

var collection = [firstSet, secondSet, thirdSet, fourthSet, fifthSet];
collection.forEach(findBigger);

function findBigger(set) {
    var biggestNum = set[0];

    set.forEach(function (number) {
        if (number >= biggestNum){
            biggestNum = number;
        }
    });

    console.log(biggestNum);
}