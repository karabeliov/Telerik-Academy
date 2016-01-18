// Write a script that finds the biggest of three numbers.
// Use nested if statements.
taskName = "The biggest of Three";

function Main(bufferElement) {

    var a = -0.1, // Change values to TEST
        b = -0.5,
        c = -1.1,
        biggest;
        
    if (a > b) {
        biggest = a;

        if (biggest < c) {
            biggest = c;
        }
    }
    else {
        biggest = b;

        if (biggest < c) {
            biggest = c;
        }
    }
   

    WriteLine("a = " + a);
    WriteLine("b = " + b);
    WriteLine("c = " + c);
    WriteLine("Biggest number is " + biggest);
}