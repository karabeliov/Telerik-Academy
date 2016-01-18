// Write an expression that calculates rectangle’s area by given width and height.
taskName = "Rectangle area";

function Main(bufferElement) {

    var width = 2.5, // Change value to TEST
        height = 3,
        area = width * height;
    WriteLine(Format("Width is {0}.", width));
    WriteLine(Format("Height is {0}.", height));
    WriteLine(Format("Rectangle area is {0}.", area));
}