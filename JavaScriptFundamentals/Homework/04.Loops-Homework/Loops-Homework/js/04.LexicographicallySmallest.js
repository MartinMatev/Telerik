
// Problem 4: Lexicographically smallest

function fourthProblem(){
	var smallestProperty = 'a';
	var largestProperty = '';
	var result = document.getElementById('fourthAnswer');

	if(document.getElementById('r1').checked){
		for (var property in document) {
			if(property < smallestProperty){
				smallestProperty = property;
			}
			if (property > largestProperty){
				largestProperty = property;
			}
		};

		result.innerHTML = 'Document - smallest: ' + smallestProperty + '; largest: ' + largestProperty;
	    console.log('Document - smallest: ' + smallestProperty + '; largest: ' + largestProperty);

	} else if(document.getElementById('r2').checked){
		for (var property in window) {
			if(property < smallestProperty){
				smallestProperty = property;
			}
			if (property > largestProperty){
				largestProperty = property;
			}
		};

		result.innerHTML = 'Window - smallest: ' + smallestProperty + '; largest: ' + largestProperty;
	    console.log('Window - smallest: ' + smallestProperty + '; largest: ' + largestProperty);

	} else if(document.getElementById('r3').checked){
		for (var property in navigator) {
			if(property < smallestProperty){
				smallestProperty = property;
			}
			if (property > largestProperty){
				largestProperty = property;
			}
		};

		result.innerHTML = 'Navigator - smallest: ' + smallestProperty + '; largest: ' + largestProperty;
	    console.log('Navigator - smallest: ' + smallestProperty + '; largest: ' + largestProperty);

	}
}