/*
 Problem 4. Average age of females

 Write a function that calculates the average age of all females, extracted from an array of persons
 Use Array#filter
 Use only array methods and no regular loops (for, while)
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

var result = people.filter(function(person){
    return person.gender === 'female';
}).reduce(function(sum, person, index, array){
    var count = array.length;
    console.log(person.name + ', gender: ' + person.gender +', is ' + person.age + ' years old');
    return (sum + person.age / count);
}, 0);

console.log('Average age : ' + result);