// Create null, undefined variables and try typeof on them.
taskName = "JavaScript";

function Main(bufferElement) {

    var integerNumber = 6,
        string = "JavaScript",
        bool = true,
        arr = [integerNumber, string, bool],
        undefinedVar,
        valueNull = null,
        objectType = new Object();
        
    WriteLine("Integer Number: " + integerNumber);
    WriteLine("String: " + string);
    WriteLine("Boolean: " + bool);
    WriteLine("Array: " + typeof arr);
    WriteLine("Undefined variable: " + undefinedVar);
    WriteLine("Null value: " + valueNull);
    WriteLine(Format("Object Type: {0}", objectType));
}