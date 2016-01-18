// Write a script that finds the lexicographically smallest and largest property in document,
// window and navigator objects.
taskName = "Lexicographically smallest";

function Main(bufferElement) {
// Input
    var objects = [document, window, navigator], // Change value to TEST
        properties = [],
        smallest,
        largest;
// Solution   
    for (var object in objects) {
        for (var proparty in objects[object]) {
            properties.push(proparty);
        }
    }

    properties.sort();
    smallest = properties[0];
    largest = properties[properties.length - 1];
// Output
    WriteLine("Smallest " + smallest);
    WriteLine("Largest  " + largest);

    //WriteLine();          // Print All Properties
    //for (var i = 0; i < properties.length; i++) {
    //    Write(properties[i] + ", ");
    //}
}