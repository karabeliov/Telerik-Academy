// Write a script that prints all the numbers from 1 to N.
taskName = "Numbers";

function Main(bufferElement) {
// Input
    var max = 300; // Change value to TEST
    // Solution and Output  
    for (var i = 1; i < max; i++) {
        Write(i + ", ");
    }

    WriteLine(max + ".");
}