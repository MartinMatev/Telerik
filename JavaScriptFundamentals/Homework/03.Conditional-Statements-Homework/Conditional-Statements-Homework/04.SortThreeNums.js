/*
    COPY PASTE THE FOLLOWING CODE IN THE BROWSER'S CONSOLE ! 
*/

/*
Problem 4. Sort 3 numbers

Sort 3 real values in descending order.
Use nested if statements.
Note: Don’t use arrays and the built-in sorting functionality.

Examples:

a	    b	    c	            result
5	    1	    2	        5       2       1
-2	    -2	    1	        1       -2      -2
-2	    4	    3	        4       3       -2
0	    -2.5    5           5       0       -2.5
-1.1    -0.5    -0.1	    -0.1    -0.5    -1.1
10	    20	    30	        30      20      10
1	    1	    1	        1       1       1
*/

var firstSet = [5, 1, 2];
var secondSet = [-2, -2, 1];
var thirdSet = [-2, 4, 3];
var fourthSet = [0, -2.5, 5];
var fifthSet = [-1.1, -0.5, -0.1];
var sixthSet = [10, 20, 30];
var seventhSet = [1, 1, 1];

var collection = [firstSet, secondSet, thirdSet, fourthSet, fifthSet, sixthSet, seventhSet];
collection.forEach(sortNumbers);

function sortNumbers(set) {
    var first = set[0];
    var second = set[1];
    var third = set[2];

    if(first >= second){
        if (second >= third){
            console.log(first +" "+ second +" "+ third);
        }
        else if(first <= third){
            console.log(third + " " + first + " " + second);
        }
        else{
            console.log(first + " " + third + " " + second);
        }
    }
    else{
        if(first >= third){
            console.log(second + " " + first + " " + third);
        }
        else if(second <= third){
            console.log(third + " " + second + " " + first);
        }
        else{
            console.log(second + " " + third + " " + first);
        }
    }
}