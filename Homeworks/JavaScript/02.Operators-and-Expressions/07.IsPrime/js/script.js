// Write an expression that checks if given positive integer number n (n ≤ 100) is prime.
taskName = "Is prime";

function Main(bufferElement) {

    var number = 97,
        isPrime = false;

    if (number == 1) {
        isPrime = false;
    }
    else if (number == 2) {
        isPrime = true;
    }
    else {
        for (i = 2; i < number; i += 2) {
            if (number % i == 0) {
                return;
            }
            else {
                isPrime = true;
            }
        }
    }

    WriteLine(number + " is prime? " + isPrime);
}