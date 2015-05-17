//Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.
taskName = "Increase array members";

function Main(bufferElement) {
// Input
    var array = []; // Change value to TEST
// Solution   
    for (var i = 0; i <= 20; i++) {
        array[i] = i * 5;
    }
// Output
    WriteLine("Array: " + array.join(", "));
    // Print array on the console. 
    console.log(array);
}