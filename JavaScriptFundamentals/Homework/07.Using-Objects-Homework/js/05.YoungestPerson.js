/*
 Problem 5. Youngest person

 Write a function that finds the youngest person in a given array of people and prints his/hers full name
 Each person has properties firstname, lastname and age.

 Example:

 var people = [
 { firstname : 'Gosho', lastname: 'Petrov', age: 32 },
 { firstname : 'Bay', lastname: 'Ivan', age: 81},… ];
 */

function fifthProblem(){
    var result = document.getElementById('youngerPersonAnswer'),
        firstPersonName = document.getElementById('inputFirstName').value,
        firstPersonLastName = document.getElementById('inputFirstLastName').value,
        firstPersonAge = document.getElementById('inputFirstAge').value,
        secondPersonName = document.getElementById('inputSecondName').value,
        secondPersonLastName = document.getElementById('inputSecondLastName').value,
        secondPersonAge = document.getElementById('inputSecondAge').value;

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

        result.innerHTML += 'Youngest person is ' + findYoungestPerson(personArray);
        console.log('Youngest person is ' + findYoungestPerson(personArray));
    }
}

function findYoungestPerson(personArray){
    var youngestPerson = personArray.reduce(function(a, b){
        return a.age - b.age > 0 ? b : a;
    });

    return youngestPerson.firstName + ' ' + youngestPerson.lastName;
}