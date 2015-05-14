// Assign all the possible JavaScript literals to different variables.
taskName = "Literals";

function Main(bufferElement) {

    var integerNumber = 6,
        string = '"JavaScript"',
        bool = true,
        arr = [integerNumber, string, bool],
        undefinedVar,
        valueNull = null,
        objectType = new Object();
        
    WriteLine("Integer Number: " + integerNumber);
    WriteLine("String: " + string);
    WriteLine("Boolean: " + bool);
    WriteLine("Array: " + arr);
    WriteLine("Undefined variable: " + undefinedVar);
    WriteLine("Null value: " + valueNull);
    WriteLine(Format("Object Type: {0}", objectType));
}