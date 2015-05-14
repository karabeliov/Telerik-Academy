// Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) 
// and out of the rectangle R(top=1, left=-1, width=6, height=2).
taskName = "Point in Circle and outside Rectangle";

function Main(bufferElement) {

    var x = 2,  // Change values to TEST
        y = 1.5,

        r = 3,
    insideK = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= 3;
    outsideR = (x >= -1 && x <= -1 + 6) && (y <= 1 && y >= 1 - 2),
    isTrue = false;
        
    if (insideK && !outsideR) {
        isTrue = true;
    }

    WriteLine("x = " + x);
    WriteLine("y = " + y);
    Write("Inside K & outside of R? ");
    WriteLine(isTrue ? "yes" : "no");
}