/**
 * Created by Matev on 5/25/2015.
 */

/*
 Problem 1. Increase array members

 Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.
 Print the obtained array on the console.
 */

function firstProblem(){
    var result = document.getElementById('firstAnswer');
    var step = 5;
    var total = 19;

    result.innerHTML = '';
    for(var i = 0; i < total; i++){
        result.innerHTML += (i * step) + ', ';
    }

    result.innerHTML =  result.innerHTML.replace(/,\s*$/, "");
    console.log('20 integers which value = index * 5: ' + result.innerHTML);
}