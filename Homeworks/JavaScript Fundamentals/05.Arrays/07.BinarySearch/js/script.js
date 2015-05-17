// Write a script that finds the index of given element in a sorted array of integers by 
// using the binary search algorithm.
taskName = "Binary search";

function Main(bufferElement) {
// Input
    var arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10], // Change value to TEST
        searchElement = 5;
        min = 0, 
        max = arr.length - 1,
        index = -1;

// Solution   
    while (min <= max) {
        var middle = min + (max - min) / 2;
        middle = Math.floor(middle);
        if (arr[middle] > searchElement) {
            max = middle - 1;
        }
        else if (arr[middle] < searchElement) {
            min = middle + 1;
        }
        else {
            index = middle;
            break;
        }
    }
// Output
    WriteLine('Index of element ' + searchElement + ' is ' + index);
}