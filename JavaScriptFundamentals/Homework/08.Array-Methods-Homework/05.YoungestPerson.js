/*
 Problem 5. Youngest person

 Write a function that finds the youngest male person in a given array of people and prints his full name
 Use only array methods and no regular loops (for, while)
 Use Array#find
 */

/*
 !!!!!!!COPY PASTE THE CODE INTO THE CONSOLE OF THE BROWSER OF YOUR CHOOSING (open the browser, press F12, select the 'Console' tab, paste the code)!!!!!!!!!!!!!
 */

var people = [
    {name: "Strahil", lastname: 'Ivanov', age: 24, gender: 'male'},
    {name: "Kiro", lastname: 'Georgiev', age: 16, gender: 'male'},
    {name: "Ivan", lastname: 'Vankov', age: 18, gender: 'male'},
    {name: "Diana", lastname: 'Kirova', age: 33, gender: 'female'},
    {name: "Sinbad", lastname: 'Gochev', age: 46, gender: 'male'},
    {name: "Ekaterina", lastname: 'Dimitrova', age: 12, gender: 'female'},
    {name: "Nikoleta", lastname: 'Kitanova', age: 8, gender: 'female'}
];

if (!Array.prototype.find) {
    Array.prototype.find = function(predicate) {
        if (this == null) {
            throw new TypeError('Array.prototype.find called on null or undefined');
        }
        if (typeof predicate !== 'function') {
            throw new TypeError('predicate must be a function');
        }
        var list = Object(this);
        var length = list.length >>> 0;
        var currentArgs = arguments[1];
        var value;

        for (var index = 0; index < length; index += 1) {
            value = list[index];
            if (predicate.call(currentArgs, value, index, list)) {
                return value;
            }
        }
        return undefined;
    };
}

function getNamesOfYoungestMale (people) {
    var youngestMale =  people.sort(function (a, b) {
        return a.age - b.age;
    }).find(function(person) {
        return person.gender === 'male';
    });

    return formatOutput(youngestMale);
}

function formatOutput(youngestMale){
    return youngestMale.name + ' ' + youngestMale.lastname +
    '(' + youngestMale.age + ', ' + (youngestMale.gender) + ')';
}

console.log(getNamesOfYoungestMale(people));