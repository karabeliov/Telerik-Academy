// Write a function that returns the last digit of given integer as an English word.
taskName = "English digit";

function Main(bufferElement) {
    // Input
    var number = 12309; // Change value to TEST
    // Solution   
    function EngDigit(number) {
        var result;
        switch (number % 10) {
            default: "error!!"
                break;
            case 0: result = "zero";
                break;
            case 1: result = "one";
                break;
            case 2: result = "two";
                break;
            case 3: result = "three";
                break;
            case 4: result = "four";
                break;
            case 5: result = "five";
                break;
            case 6: result = "six";
                break;
            case 7: result = "seven";
                break;
            case 8: result = "eight";
                break;
            case 9: result = "nine";
                break;
        }

        return result;
    }
    // Output
    WriteLine(number + " last digit is -> " + EngDigit(number));
}