// Write an expression that checks if given integer is odd or even.
taskName = "Odd or Even";

function Main(bufferElement) {

    var number = 2;  // change value to TEST 
        
    if (number % 2 === 0) {
        WriteLine(Format("Number \"{0}\" is even", number));
    }
    else {
        WriteLine(Format("Number \"{0}\" is odd", number));
    }
}