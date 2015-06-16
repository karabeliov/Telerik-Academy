/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum(arr) {
	var i, 
	len,
	sum = 0;
	
	if(arr === undefined) { // check if input is uncorrent
		throw 'not Array'
	}
	
	len = arr.length;
	if(len === 0) { // check if array is empty
		return null;
	}
	
	for(i = 0, len = arr.length; i < len; i += 1) {
	    if (isNaN(arr[i])) { // check if not a number trow ERROR
	        throw 'Number must be of type Number';
	    }
		
		sum += +arr[i]; // parse number and sum it
	}
	
	return sum;
}

module.exports = sum;