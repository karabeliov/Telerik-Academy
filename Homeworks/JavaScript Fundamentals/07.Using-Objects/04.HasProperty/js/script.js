// Write a function that checks if a given object contains a given property.
taskName = "Has property";

function Main(bufferElement) {
// Input
    var person = { // Change value to TEST
        fname: "Super",
        lname: "Mario"
    }, 
    hasProp = hasProperty(person, 'fname');
// Solution   
    function hasProperty(obj, prop) {
        var result = '"' + prop + '"' + " in this object -> ";
        if (obj.hasOwnProperty(prop)) {
            result += true;
        }
        else {
            result += false;
        }

        return result;
    }
// Output
    WriteLine("Has Property " + hasProp);
}