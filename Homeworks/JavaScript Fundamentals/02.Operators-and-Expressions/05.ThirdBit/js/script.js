// Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
// The bits are counted from right to left, starting from bit #0.
// The result of the expression should be either 1 or 0.
taskName = "Third bit";

function Main(bufferElement) {

    var number = 5343; // Change value to TEST
    var binary = number.toString(2);
    if (number < 10) {
        thirdBit = number >> 3;
    }
    else {
        thirdBit = (binary / 100);
        thirdBit = Math.floor(thirdBit) % 10;
    }

    WriteLine("Number " + number);
    WriteLine("Binary presentation " + binary);
    WriteLine("Third #3 bit is? " + thirdBit);
}