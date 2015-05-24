/*
    COPY PASTE THE FOLLOWING CODE IN THE BROWSER'S CONSOLE ! 
*/

/*
Problem 8. Number as words

Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.
Examples:

numbers	number as words
0	    Zero
9	    Nine
10	    Ten
12	    Twelve
19	    Nineteen
25	    Twenty five
98	    Ninety eight
273	    Two hundred and seventy three
400	    Four hundred
501	    Five hundred and one
617	    Six hundred and seventeen
711	    Seven hundred and eleven
999	    Nine hundred and ninety nine
*/

var numbers = [0, 9, 10, 12, 19, 25, 98, 273, 400, 501, 617, 711, 999];
wordConverter(numbers);

function wordConverter(numbersSet){
    numbersSet.forEach(function (number) {
        var numberInWords = "";

        var belowTwenty = ["Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
                                   "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"];
        var aboveTwenty = ["", "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"];
        var remainder = number % 10;
        var isNotZero = remainder != 0;
        var hundreds = Math.floor(number / 100);

        // If the number is below twenty, search for it in the first array, by passing the numbers as a element indicator
        if (number <= 19) {
            numberInWords += belowTwenty[number];
            console.log(numberInWords);
        }
        else if (number >= 20 && number <= 99) {
            // if its between 20 and 99, divide it by ten to get the frist digit, and use it to search through the aboveTwenty array for the appropriate translation
            number = Math.floor(number / 10);
            numberInWords += aboveTwenty[number] + " ";

            // If the second digit of the number is NOT 0, then use the remainder of the division by 10 to get the second digit in words
            if (isNotZero) {
                numberInWords += belowTwenty[remainder].toLowerCase();
            }
            console.log(numberInWords);
        }
        else {
            var tempNumber = number;
            number = Math.floor(number / 10);
            var tens = number % 10;
            numberInWords += belowTwenty[hundreds] + " hundred ";

            // Check if the tens are 1. In that case, divide the number by 100 and assign the tens variable the remainder. Ex: 519 % 100 = 0.19 as a remainder
            if (tens == 1) {
                tens = tempNumber % 100;
                numberInWords += "and " + belowTwenty[tens].toLowerCase() + " ";
            }
            else if (tens == 0 && !isNotZero) {
                // If both the tens and the last digit are 0, get in here to skip display the last digit in words. I.e 500 = five hundred, not five hundred and zero
                numberInWords += aboveTwenty[tens].toLowerCase() + " ";
            }
            else {
                // assigning the tens meaning in words, if its anything but 1 and 0
                numberInWords += "and " + aboveTwenty[tens].toLowerCase() + " ";

                // If the last digit is NOT 0, then search for its wording in the below twenty array
                if (isNotZero) {
                    numberInWords += belowTwenty[remainder].toLowerCase();
                }
            }
            console.log(numberInWords);
        }
    });
};

