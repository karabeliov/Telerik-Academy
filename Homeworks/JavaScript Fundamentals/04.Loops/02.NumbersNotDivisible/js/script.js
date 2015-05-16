// Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time
taskName = "Numbers not divisible";

function Main(bufferElement) {
// Input
    var max = 100; // Change value to TEST
// Solution   
    for (var i = 1; i < max; i++) {
        if (i % 3 !== 0 && i % 7 !== 0) {
            Write(i + ", ");
        }
    }
// Output
WriteLine(max + ".");
}