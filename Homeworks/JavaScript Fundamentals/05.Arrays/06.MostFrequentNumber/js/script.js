// Write a script that finds the most frequent number in an array.
taskName = "Most frequent number";

function Main(bufferElement) {
// Input
    var arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3], // Change value to TEST
        elementMax,
        counter = 0,
        maxCount = 0;
// Solution   
    for (var i = 0; i < arr.length; i++) {
        for (var j = 0; j < arr.length; j++) {
            if (arr[i] === arr[j]) {
                 counter++;
                 if (maxCount < counter) {
                     maxCount = counter;
                     elementMax = arr[i];
                 }
             }
        }

        counter = 0;
    }
    // Output
    WriteLine(Format("Result: {0} ( {1} times)", elementMax, maxCount));
}