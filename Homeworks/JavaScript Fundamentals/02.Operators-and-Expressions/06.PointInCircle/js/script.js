// Write an expression that checks if given point P(x, y) is within a circle K(O, 5).
taskName = "Point in Circle";

function Main(bufferElement) {

    var x = -1,
        y = 2,
        isInside = (x * x + y * y) < 5 * 5;

    WriteLine("circle K(O, 5)");
    WriteLine("x = " + x);
    WriteLine("y = " + y);
    WriteLine("Point in Circle? " + isInside);
}