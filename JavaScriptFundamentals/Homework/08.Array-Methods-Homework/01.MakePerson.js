/*
 Problem 1. Make person

 Write a function for creating persons.
 Each person must have firstname, lastname, age and gender (true is female, false is male)
 Generate an array with ten person with different names, ages and genders
 */

/*
 !!!!!!!COPY PASTE THE CODE INTO THE CONSOLE OF THE BROWSER OF YOUR CHOOSING (open the browser, press F12, select the 'Console' tab, paste the code)!!!!!!!!!!!!!
 */

var people = generatePeople();
people.forEach(function (human) {
   console.log(human);
});

function generatePeople() {
    var peopleFirstNames = ['Ivan', 'Georgi', 'Kiro', 'Strahil', 'Nadia', 'Nikoleta', 'Miglena', 'Dobromir', 'Dimitar', 'John'],
        peopleLastNames = ['Ivanov', 'Georgiev', 'Vankov', 'Gochev', 'Kirova', 'Dimitrova', 'Ekaterinova', 'Tenekidjiev', 'Kitanov', 'Doe'],
        result = [],
        index;



    for(index = 0; index < 10; index += 1){
        result[index] = generateHuman(peopleFirstNames[index], peopleLastNames[index], Math.floor(Math.random() * 100), index % 2 == 0 ? true:false);
    }

    return result;
}

function generateHuman(firstName, lastName, age, sex) {
    return {
        firstname: firstName,
        lastname: lastName,
        age: age,
        gender: sex ? 'female' : 'male'
    };
}