/*
 Problem 3. Underage people

 Write a function that prints all underaged persons of an array of person
 Use Array#filter and Array#forEach
 Use only array methods and no regular loops (for, while)
 */

/*
 !!!!!!!COPY PASTE THE CODE INTO THE CONSOLE OF THE BROWSER OF YOUR CHOOSING (open the browser, press F12, select the 'Console' tab, paste the code)!!!!!!!!!!!!!
 */

var people = [
    {name: "Strahil", age: 24},
    {name: "Kiro", age: 16},
    {name: "Ivan", age: 18},
    {name: "Diana", age: 33},
    {name: "Sinbad", age: 46},
    {name: "Ekaterina", age: 12},
    {name: "Niki", age: 8}
];

people.filter(function(person){
    return person.age < 18;
}).forEach(function (person) {
    console.log(person);
});