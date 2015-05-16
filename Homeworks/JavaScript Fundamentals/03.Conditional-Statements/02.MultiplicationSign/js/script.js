// Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
// Use a sequence of if operators.
taskName = "Multiplication Sign";

function Main(bufferElement) {

    var a = -5, // Change values to TEST
        b = 2.5,
        c = -2,
        result;
        
    if (a === 0 || b === 0 || c === 0) {
        result = 0;
    }
    else if (a > 0 && b > 0 && c > 0) {
        result = "+";
    }
    else if (a < 0 && b < 0 && c < 0) {
        result = "-";
    }
    else if (a > 0 && b > 0 && c < 0) {
        result = "-";
    }
    else if (a > 0 && b < 0 && c > 0) {
        result = "-";
    }
    else if (a < 0 && b > 0 && c > 0) {
        result = "-";
    }
    else {
        result = "+";
    }

    if (result === 0) {
        WriteLine(Format("{0} * {1} * {2} = 0", a, b, c, result));
    }
    else {
        WriteLine(Format("{0} * {1} * {2} = {3} sign", a, b, c, result));
    }  
}