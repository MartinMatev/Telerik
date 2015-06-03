/*
 Problem 3. Deep copy

 Write a function that makes a deep copy of an object.
 The function should work for both primitive and reference types
 */

function thirdProblem(){
    var result = document.getElementById('deepCopyAnswer');
    result.innerHTML = '';

    var testString = 'test string property',
        testArray = [3, 1, 6, 4, 2, 13, 37],
        testObject = {
            firstTestObject: {
                name: 'Strahil Chukov', occupation: 'Traktorist', experienceInYears: 27
            },
            secondTestObject: {
                name: 'Kiro Ivanov', occupation: 'Hakerist', experienceInYears: 1337
            }
        };
    var clonedObject;

    result.innerHTML += '<br/>' + '"String" result: '+ deepClone(testString);
    result.innerHTML += '<br/>' + '"Array" result: ' +deepClone(testArray);
    clonedObject = deepClone(testObject);
    result.innerHTML += '<br/>' + '"Object" result: ' + JSON.stringify(clonedObject, null, 4);

    console.log('<br/>' + '"String" result: '+ deepClone(testString));
    console.log('<br/>' + '"Array" result: ' +deepClone(testArray));
    console.log('<br/>' + '"Object" result: ' + JSON.stringify(clonedObject, null, 4));
}

function deepClone(data){
    if(data === null || typeof(data) !== 'object'){
        return data;
    }
    else{
        var clonedData = data.constructor();

        for(var key in data){
            // Recursion. Used to copy the property and it's appropriate properties: value/s
            if(Object.prototype.hasOwnProperty.call(data, key)) {
                clonedData[key] = deepClone(data[key]);
            }
        }

        return clonedData;
    }
}