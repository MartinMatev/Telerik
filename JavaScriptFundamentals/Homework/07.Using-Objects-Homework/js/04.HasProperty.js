/*
 Problem 4. Has property

 Write a function that checks if a given object contains a given property.

 var obj  = …;
 var hasProp = hasProperty(obj, 'length');
 */

function fourthProblem(){
    var result = document.getElementById('propertyCheckAnswer'),
        inputProperty = document.getElementById('inputProperty').value;
    result.innerHTML = '';

    if(inputProperty === '' || !inputProperty.match(/\S/)){
        result.innerHTML += 'Wrong data input!';
        console.log('Wrong input data!');
    }
    else {
        var testObject = {name: 'Strahil Chukov', occupation: 'Traktorist', experienceInYears: 27};

        result.innerHTML += 'The input property is present in the current object - ' + propertySearch(testObject, inputProperty);
        console.log('The input property is present in the current object - ' + propertySearch(testObject, inputProperty));
    }
}

function propertySearch(obj, prop){
    return obj.hasOwnProperty(prop);
}