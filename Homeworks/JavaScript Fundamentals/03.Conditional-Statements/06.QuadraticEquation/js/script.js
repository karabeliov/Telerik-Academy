// Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it 
// (prints its real roots).
// Calculates and prints its real roots.
taskName = "Quadratic equation";

function Main(bufferElement) {
    // Input
    var a = 5, // Change value to TEST
        b = 2,
        c = 8,
    // Solution
        disk = Math.sqrt(b * b - 4 * a * c),
        x1 = (-b - disk) / (2 * a),
        x2 = (-b + disk) / (2 * a);
    // Output
    WriteLine("ax2 + bx + c = 0");
    WriteLine();
    WriteLine("a = " + a);
    WriteLine("b = " + b);
    WriteLine("c = " + c);
    WriteLine();

    if (isNaN(x1) && isNaN(x2)) {
        WriteLine("no real roots");
    }
    else if (x1 === x2) {
        WriteLine("x1 = x2 = " + x1);
    }
    else {
        WriteLine("x1 = " + x1);
        WriteLine("x2 = " + x2);
    }
    
}