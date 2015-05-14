// Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
taskName = "Divisible by 7 and 5";

function Main(bufferElement) {

    var number = 140; // change value to TEST
    var isTrue = false;
    if (number % 5 === 0 && number % 7 === 0) {
        isTrue = true;
    }

    Write("Number \"" + number + "\" ");
    Write(isTrue ? "can be " : "can not be ");
    Write("divided by 7 and 5 (without remainder)!");
}