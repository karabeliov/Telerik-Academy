// Sort 3 real values in descending order.
// Use nested if statements
taskName = "Sort 3 numbers";

function Main(bufferElement) {

    var a = 10, // Change values to TEST
        b = 20,
        c = 30,
        small,
        middle,
        biggest;

    if (a >= b && a >= c) { // Biggest a
        biggest = a;

        if (b > c) {
            middle = b;
            small = c;
        }
        else {
            middle = c;
            small = b;
        }
    }

    if (b >= a && b >= c) { // Biggest b
        biggest = b;

        if (a > c) {
            middle = a;
            small = c;
        }
        else {
            middle = c;
            small = a;
        }
    }

    if (c >= b && c >= c) { // Biggest c
        biggest = c;

        if (b > a) {
            middle = b;
            small = a;
        }
        else {
            middle = a;
            small = b;
        }
    }

    WriteLine(biggest + " " + middle + " " + small);
}