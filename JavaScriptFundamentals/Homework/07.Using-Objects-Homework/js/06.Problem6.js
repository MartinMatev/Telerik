/*
 Write a function that groups an array of people by age, first or last name.
 The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
 Use function overloading (i.e. just one function)

 Example:

 var people = {…};
 var groupedByFname = group(people, 'firstname');
 var groupedByAge= group(people, 'age');
 */


function sixthProblem(){
    var result = document.getElementById('sortingProblemAnswer'),
        firstPersonName = document.getElementById('inputGroupFirstName').value,
        firstPersonLastName = document.getElementById('inputGroupFirstLastName').value,
        firstPersonAge = document.getElementById('inputGroupFirstAge').value,
        secondPersonName = document.getElementById('inputGroupSecondName').value,
        secondPersonLastName = document.getElementById('inputGroupSecondLastName').value,
        secondPersonAge = document.getElementById('inputGroupSecondAge').value,
        radios = document.getElementsByName('groupType');

    result.innerHTML = '';

    if(firstPersonAge === '' || !firstPersonAge.match(/\S/)
        || secondPersonAge === '' || !secondPersonAge.match(/\S/)
        || isNaN(firstPersonAge) || isNaN(secondPersonAge)
        || firstPersonAge < 0 || secondPersonAge < 0){
        result.innerHTML += 'AGE must be a positive number!';
        console.log('AGE must be a positive number!')
    }
    else{
        var personArray = [
            {firstName: firstPersonName, lastName: firstPersonLastName, age: firstPersonAge},
            {firstName: secondPersonName, lastName: secondPersonLastName, age: secondPersonAge}
        ];

        var checkValue = getCheckedRadio(radios);
        var groupedResult = groupBy(personArray, checkValue);

        result.innerHTML += 'The function must return an associative array, with keys - the groups, and values - arrays with people in this groups' + '<br/>' + 'You will find the result in the CONSOLE is better structured!' + '<br/>';
        result.innerHTML += '<br/>' + 'Grouped By: ' + checkValue + '<br/>' + JSON.stringify(groupedResult, null, 4);
        console.log('Grouped By: ' + checkValue + JSON.stringify(groupedResult, null, 4));
    }
}

function groupBy(personArray, property){
    var res = {};

    personArray.forEach(function(person){
        var value = person[property];
        res[value] = res[value] || []
        res[value].push(person);
    });
    return res;
}

function getCheckedRadio(radios) {
    var checked;
    for (var i = 0; i < radios.length; i += 1) {
        if (radios[i].checked) {
            checked = radios[i].id;
            break;
        }
    }

    return checked;
}
