// Write a JavaScript function that reverses a string and returns it.
taskName = "Reverse string";

function Main(bufferElement) {
// Input
    var string = "JavaScript"; // Change value to TEST
        
// Solution   
    function reverse(string) {
        var result = "";
        for (var i = 0; i < string.length; i++) {
            result += string[string.length - 1 - i];
        }

        return result;
    }
    // Output
    WriteLine("String: " + string);
    WriteLine("String after reversed: " + reverse(string));
}