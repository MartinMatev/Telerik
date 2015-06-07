/*
 Problem 2. People of age

 Write a function that checks if an array of person contains only people of age (with age 18 or greater)
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

people.forEach(function (person) {
   if(person.age >= 18){
       console.log(person.name + 'is ' + person.age + ' years old');
   }
});