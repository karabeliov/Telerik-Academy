//Write an if statement that takes two double variables a and b and exchanges their values 
//if the first one is greater than the second.
//As a result print the values a and b, separated by a space.
taskName = "Exchange if greater";

function Main(bufferElement) {

    var a = 5.5, // Change values to TEST
        b = 4.5,
        result;
        
    if (a < b) {
        result = a + " " + b;
    }
    else {
        result = b + " " + a;
    }

    WriteLine("a = " + a);
    WriteLine("b = " + b);
    WriteLine("result = " + result);
}