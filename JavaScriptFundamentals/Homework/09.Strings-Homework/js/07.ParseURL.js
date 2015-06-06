/*
 Problem 7. Parse URL

 Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
 Return the elements in a JSON object.
 Example:

 URL	result
 http://telerikacademy.com/Courses/Courses/Details/239	{ protocol: http,
 server: telerikacademy.com
 resource: /Courses/Courses/Details/239
 */

function seventhProblem(){
    var inputUrl = document.getElementById('urlText').value,
        result = document.getElementById('urlInfoAnswer');

    result.innerHTML = '';
    var arr = parseURL(inputUrl);

    arr.forEach(function(element){
        result.innerHTML += 'protocol: ' + element.protocol + '<br/>';
        result.innerHTML += 'server: ' + element.host + '<br/>';
        result.innerHTML += 'resource: ' + element.pathname + '<br/>';
    });
    console.log(JSON.stringify(arr, null, 4))
}

function parseURL(url) {
    var parser = document.createElement('a'),
        searchObject = {},
        queries, split, i;
    // Let the browser do the work
    parser.href = url;
    // Convert query string to object
    queries = parser.search.replace(/^\?/, '').split('&');
    for( i = 0; i < queries.length; i++ ) {
        split = queries[i].split('=');
        searchObject[split[0]] = split[1];
    }
    return [{
        protocol: parser.protocol,
        host: parser.host,
        hostname: parser.hostname,
        port: parser.port,
        pathname: parser.pathname,
        search: parser.search,
        searchObject: searchObject,
        hash: parser.hash
    }];
}