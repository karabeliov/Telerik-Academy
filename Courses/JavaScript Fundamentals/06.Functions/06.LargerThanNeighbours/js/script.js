// Write a function that checks if the element at given position
// in given array of integers is bigger than its two neighbours (when such exist).
taskName = "Larger than neighbours";

function Main(bufferElement) {
    // Input
    var arr = [5, 8, 9, 5, 43, 2, 7, 87, 98, 3, 2, 7, 8], // Change value to TEST
    index = 12,
    answer;
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
    // Output
    WriteLine("Larger than neighbours? " + isBigger(arr, index));
}