
// Problem 3: Min/Max of sequence

function thirdProblem(){
	var input = document.getElementById('thirdNumber').value;
	var result = document.getElementById('thirdAnswer');
	var minValue = '';
	var maxValue = '';

	// Check if the textbox is empty OR has only spaces as input!
	if(input === '' || !input.match(/\S/)){
		result.innerHTML = 'Input cannot be empty!';
		return;
	} else{
		var numbersArray = input.split(' ');
		for (var i = 0; i < numbersArray.length; i++) {
			
			if(isNaN(numbersArray[i])){
				result.innerHTML = 'Please enter a valid SEQUENCE.Sequence must contain ONLY positive integers!';
				return;
			}
		};
	}

	numbersArray.sort(compareNumbers);
	minValue = numbersArray[0];
	maxValue = numbersArray[numbersArray.length - 1];

	result.innerHTML = 'MIN: ' + minValue + '<br/>' +'MAX: ' + maxValue;
	console.log("Min value: " + numbersArray[0]);
	console.log("Max value: " + numbersArray[numbersArray.length - 1]);
}

function compareNumbers(a, b) {
  return a - b;
}
