// Sorting an array means to arrange its elements in increasing order.
// Write a script to sort an array.
// Use the selection sort algorithm: Find the smallest element, move it at the first position,
// find the smallest from the rest, move it at the second position, etc.
taskName = "Selection sort";

function Main(bufferElement) {
// Input
    var arr = [4, 8, 4, 2, 54, 74, 4, 235, 6, 2], // Change value to TEST
        currentMin;
// Solution   
     for (var i = 0; i < arr.length; i++) {
         currentMin = i;
         for (var j = i + 1; j < arr.length; j++) {
             if (arr[currentMin] > arr[j]) {
                 currentMin = j;
             }
         }

         var temp = arr[i];
         arr[i] = arr[currentMin];
         arr[currentMin] = temp;
    }
// Output
WriteLine("Sorted array: " + arr.join(", "));
}