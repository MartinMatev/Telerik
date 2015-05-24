
// Problem 2: Numbers not divisible

function secondProblem(){
	var inputNumber = document.getElementById('secondNumber').value;
	var result = document.getElementById('secondAnswer');
	var index;

	if(!isNaN(inputNumber) && inputNumber != '' && inputNumber > 0){
		result.innerHTML = '';           
		console.log('Numbers from 1 to ' + inputNumber);

		for (var index = 0; index <= inputNumber; index++) {

			if(index % 5 != 0 && index % 7 != 0){
				console.log(index);
				result.innerHTML += index + ', ';
			}			
		};
	} else{
		result.innerHTML = 'Please make sure to type in a POSITIVE INTEGER, not w/e you just did put in the box.';
	}
	// Remove the last comma when the loop is over /using regex/
    result.innerHTML =  result.innerHTML.replace(/,\s*$/, "");
}