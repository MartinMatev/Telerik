/*
 Problem 8. Replace tags

 Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
 Example:

 input	output
 <p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>	<p>Please visit [URL=http://academy.telerik.com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
 */

function eighthProblem(){
    var input = document.getElementById('replaceHrefTag').value,
        result = document.getElementById('replacedHrefTagAnswer'),
        display = document.getElementById('displayOriginal');

    result.innerHTML = '';
    display.innerHTML = '';

    var answer = replaceHref(input);
    display.innerHTML += 'Original text: ' + '<br/>' + input;
    result.innerHTML += 'Result: ' + '<br/>' + answer;
    console.log(answer);
}

function replaceHref(text){
    return text.replace(/<a href="(.*?)">(.*?)<\/a>/g, '[URL=$1]$2[/URL]');
}