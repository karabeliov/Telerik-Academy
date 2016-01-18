// Write a function that makes a deep copy of an object.
// The function should work for both primitive and reference types.
taskName = "Deep copy";

function Main(bufferElement) {
    // Input
    var number = 6, // Change value to TEST
        person = {
            firstName: "Super",
            lastName: "Mario",
            talk: function talking(word) {
                word = word || "Hi";
                return "Mario said: " + word;
            }
        };

    // Solution   
    function deepCopy(obj) {
        var clone = {};
        for (var i in obj) {
            if (typeof (obj[i]) == "object" && obj[i] != null) {
                clone[i] = deepCopy(obj[i]);
            }
            else {
                clone[i] = obj[i];
            }
        }

        return clone;
    }

    var copy = deepCopy(person);
    copy.firstName = "Kris";
    // Output
    WriteLine("Before copy: " + person.firstName);
    WriteLine("Copy: " + copy.firstName);
    WriteLine("After copy: " + person.firstName);
}