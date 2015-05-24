/*
    COPY PASTE THE FOLLOWING CODE IN THE BROWSER'S CONSOLE ! 
*/

/*
Problem 7. The biggest of five numbers

Write a script that finds the greatest of given 5 variables.
Use nested if statements.
Examples:

a	    b	    c	    d	    e	    biggest
5	    2	    2	    4	    1	    5
-2	    -22	    1	    0	    0	    1
-2	    4	    3	    2	    0	    4
0	    -2.5    0	    5	    5	    5
-3	    -0.5    -1.1    -2	    -0.1	-0.1
*/

var firstSet = [5, 2, 2, 4, 1];
var secondSet = [-2, -22, 1, 0, 0];
var thirdSet = [-2, 4, 3, 2, 0];
var fourthSet = [0, -2.5, 0, 5, 5];
var fifthSet = [-3, -0.5, -1.1, -2, -0.1];

var collection = [firstSet, secondSet, thirdSet, fourthSet, fifthSet];
var counter = 0;

collection.forEach(function (set) {
    // Assign the first element of the array as the biggest number
    biggerNumber = set[0];

    //Check if any of the other elements is bigger in value. If so, it becomes the new biggest number.
    for (var i = 1; i < set.length; i++) {
        if (biggerNumber < set[i]) {
            biggerNumber = set[i];
        }
    }

    console.log("The biggest of " + collection[counter] + " is " + biggerNumber);
    counter++;
});

