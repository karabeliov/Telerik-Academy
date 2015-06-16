/* Task description */
/*
	Write a function a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `string`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes(start , end) {
	var i, j,
	start = +start,
	end = +end,
	num,
	isPrime,
	maxDividor,
	result = [];
    
	if(start == undefined || end == undefined) { 
		throw 'Error any of the range params is missing ' ;
	}
	
	if(isNaN(start) || isNaN(end)) { 
		throw 'Error input is not array';
	}
	
	for(i = start; i <= end; i += 1) {
		num = i;
		maxDividor = Math.sqrt(num);
		isPrime = true;
	  for (j = 2; j <= maxDividor ; j += 1) {
			if (num % j == 0) {
				isPrime = false;
				break;
			}
		}	
		
		if (isPrime && num > 1) {
			result.push(num);
		}
	}	
		
	return result;
}

module.exports = findPrimes;