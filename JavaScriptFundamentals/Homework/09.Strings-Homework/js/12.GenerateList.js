/*
 Problem 12. Generate list

 Write a function that creates a HTML <ul> using a template for every HTML <li>.
 The source of the list should be an array of elements.
 Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.
 Example: HTML:

 <div data-type="template" id="list-item">
 <strong>-{name}-</strong> <span>-{age}-</span>
 /div>
 JavaScript:

 var people = [{name: 'Peter', age: 14},…];
 var tmpl = document.getElementById('list-item').innerHtml;
 var peopleList = generateList(people, template);
 //peopleList = '<ul><li><strong>Peter</strong> <span>14</span></li><li>…</li>…</ul>'
 */

function twelfthProblem(){
    var template = document.getElementById('list-item'),
        carsArray = [
            {brand: 'BMW', model: '330xd'},
            {brand: 'Mitsubishi', model: 'Lancer Evolution 8'},
            {brand: 'Mazda', model: '6'},
            {brand: 'VW', model: 'Sirocco'},
            {brand: 'Eagle', model: 'Talon'},
        ];

    template.outerHTML = generateList(carsArray, template.innerHTML);
    console.log(generateList(carsArray, template.innerHTML));
}

function generateList(cars, template) {
    var result = '<ul>'
    cars.forEach(function(car) {
        result += '<li>'
        result += template.replace(/-\{(.*?)}-/g, function(match, placeholder) {
            return car[placeholder]
        })
        result += '</li>'
    })
    result += '</ul>'
    return result
}