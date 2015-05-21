// Write a function that removes all elements with a given value.
// Attach it to the array type.
// Read about prototype and how to attach methods.
taskName = "Remove elements";

function Main(bufferElement) {
// Input
    var removeElement = 1, // Change value to TEST
    arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
// Solution   
    Array.prototype.remove = function myfunction(element) {
        var result = [];
        for (var i = 0; i < arr.length; i++) {
            if (arr[i] === element) {
                arr[i] = undefined;
            }

            if (arr[i] !== undefined) {
                result.push(arr[i]);
            }
        }

        return result;
    }
// Output
    WriteLine("Array: " + arr.remove(removeElement));
}