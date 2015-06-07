/*
 Problem 6. Group people

 Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
 Use Array#reduce
 Use only array methods and no regular loops (for, while)
 Example:

 result = {
    'a': [{
        firstname: 'Asen',

    }, {
        firstname: 'Anakonda',

    }],
    'j': [{
        firstname: 'John',

    }]
};
 */

/*
 !!!!!!!COPY PASTE THE CODE INTO THE CONSOLE OF THE BROWSER OF YOUR CHOOSING (open the browser, press F12, select the 'Console' tab, paste the code)!!!!!!!!!!!!!
 */

var people = [
    {name: "Strahil", age: 24, gender: 'male'},
    {name: "Kiro", age: 16, gender: 'male'},
    {name: "Ivan", age: 18, gender: 'male'},
    {name: "Diana", age: 33, gender: 'female'},
    {name: "Sinbad", age: 46, gender: 'male'},
    {name: "Ekaterina", age: 12, gender: 'female'},
    {name: "Nikoleta", age: 8, gender: 'female'}
];

var result = people.reduce(function(obj, person) {
    if (obj[person.name[0]]) {
        obj[person.name[0]].push(person);
    } else {
        obj[person.name[0]] = [person];
    }
    return obj;
}, {});

console.log(result);