// Write a function that reverses the digits of given decimal number.
taskName = "Reverse number";

function Main(bufferElement) {
// Input
    var input = 1234.56789; // Change value to TEST
// Solution   
    function reverse(input) {
        input = input.toString();
        var result = "";
        for (var i = input.length - 1; i >= 0; i--) {
            result += input[i];
        }

        return result;
    }
// Output
    WriteLine("Reverse: " + reverse(input));
}