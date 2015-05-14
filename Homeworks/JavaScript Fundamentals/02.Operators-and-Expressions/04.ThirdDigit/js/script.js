// Write an expression that checks for given integer if its third digit (right-to-left) is 7.
taskName = "Third digit 7?";

function Main(bufferElement) {

    var number = 9999799, // Change value to TEST
        isTrue = false;

    var result = (number / 100) % 10;
    result = Math.floor(result);
    if (result === 7) {
        isTrue = true;
    }

    WriteLine(Format(("{0} third digit is 7? {1}"), number, isTrue));
}