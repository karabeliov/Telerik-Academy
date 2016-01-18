// Create null, undefined variables and try typeof on them.
taskName = "Type Of Null and Undefined";

function Main(bufferElement) {

    var undefinedVar,
        valueNull = null;

    WriteLine("Undefined variable: " + typeof undefinedVar);
    WriteLine("Null value: " + typeof valueNull);
}