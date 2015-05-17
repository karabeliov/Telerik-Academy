// Write a script that finds the maximal increasing sequence in an array.
taskName = "Maximal increasing sequence";

function Main(bufferElement) {
    // Input
    var arr = [3, 2, 3, 4, 2, 2, 4], // Change value to TEST
        currentValue,
        wasHere = false,
        result = [];
    // Solution 
    for (var i = 1; i < arr.length; i++) {
        currentValue = arr[i - 1];
        if (arr[i] === currentValue + 1) {
            if (wasHere) {
                wasHere = false;
                result.push(arr[i]);
                continue;
            }
            else {
                result.push(arr[i - 1]);
            }
            
            result.push(arr[i]);

            wasHere = true;
        }
    }
    // Output
    WriteLine("Result: " + result);
}