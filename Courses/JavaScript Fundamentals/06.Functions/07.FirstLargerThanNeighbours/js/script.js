// Write a function that returns the index of the first element
// in array that is larger than its neighbours or -1, if there’s no such element.
// Use the function from the previous exercise.
taskName = "First larger than neighbours";

function Main(bufferElement) {
    // Input
    var arr = [5, 8, 9, 5, 43, 2, 7, 87, 98, 3, 2, 7, 8], // Change value to TEST
    index;
    // Solution   
    function isBigger(arr, index) {
        if (index + 1 === arr.length) { // Last
            if (arr[index] > arr[index - 1]) {
                answer = "Yes";
            }
            else {
                answer = "No";
            }
        }
        else if (index - 1 < 0) { // First
            if (arr[index] > arr[index + 1]) {
                answer = "Yes";
            }
            else {
                answer = "No";
            }
        }
        else { // Middle
            if (arr[index] > arr[index + 1] && arr[index] > arr[index - 1]) {
                answer = "Yes";
            }
            else {
                answer = "No";
            }
        }

        return answer;
    }

    function firstBigger(arr) {
        var findIndex;
        for (var i = 0; i < arr.length; i++) {
            if (isBigger(arr, i) === "Yes") {
                findIndex = i;
                break;
            }
        }

        return findIndex;
    }
    // Output
    WriteLine("Index of the first larger element than neighbours is " + firstBigger(arr) + "!");
}