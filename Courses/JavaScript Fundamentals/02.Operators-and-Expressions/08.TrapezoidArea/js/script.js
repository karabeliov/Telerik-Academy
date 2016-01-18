// Write an expression that calculates trapezoid's area by given sides a and b and height h.
taskName = "Trapezoid area";

function Main(bufferElement) {

    var a = 8.5, // Change values to TEST
        b = 4.3,
        h = 2.7
        area = ((a + b) / 2) * h;

    WriteLine("a = " + a);
    WriteLine("b = " + b);
    WriteLine("h = " + h);
    WriteLine("Trapezoid area = " + area);
}