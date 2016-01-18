// Write a script that compares two char arrays lexicographically (letter by letter).
taskName = "Lexicographically comparison";

function Main(bufferElement) {
    // Input
    var arr1 = ["abc", "bbb", "zxy", "xxx", "zzz"], // Change value to TEST
        arr2 = ["abc", "bbb", "zxy", "xxx", "zzz"],
        length = Math.max(arr1.length, arr2.length);
    // Solution and Output   
    if (arr1.length > arr2.length) {
        WriteLine('Second array is earlier.');
    }
    else if (arr1.length === arr2.length) {
        for (var i = 0; i < arr1.length; i++) {
            if (arr1[i] > arr2[i]) {
                WriteLine('Second array is earlier.');
                break;
            }
            else if (arr1[i] < arr2[i]) {
                WriteLine('First array is earlier.');
                break;
            }
            else {
                WriteLine('Arrays are equal.');
                break;
            }
        }
    }
    else {
        WriteLine('First array is earlier.');
    }
}